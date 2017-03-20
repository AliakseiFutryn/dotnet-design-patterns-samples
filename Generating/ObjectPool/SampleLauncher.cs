using System;
using System.Threading;
using System.Threading.Tasks;
using ObjectPool.Impl;
using ObjectPool.Entities;
using ObjectPool.Entities.Enums;

namespace ObjectPool
{
	class SampleLauncher
	{
		static Barrier _barrier;

		static void Main(string[] args)
		{
			// Synhronization construction.
			_barrier = new Barrier(3, barrier =>
			{
				if (barrier.CurrentPhaseNumber == 1)
				{
					Console.WriteLine(Pool<MobilePhone>.GetPoolStatus());
					Console.WriteLine("Please enter any key to exit...");
				}
			});

			Task[] displayTasks = new[]
			{
				GetDisplayTask(Company.Apple),
				GetDisplayTask(Company.Google),
				GetDisplayTask(Company.Microsoft),
			};
			Console.ReadKey();
		}

		/// <summary>
		/// Gets the two display tasks, needed to 
		/// show that just one entity was used.
		/// </summary>
		/// <param name="company">The company.</param>
		/// <returns>The display task.</returns>
		static Task GetDisplayTask(Company company)
		{
			return Task.Factory.StartNew(() => DisplayPooledObject(company))
				.ContinueWith(task => Task.Factory.StartNew(() => DisplayPooledObject(company)));
		}
		
		/// <summary>
		/// Method which is responsible for getting an object from poll
		/// and then display info of this object.
		/// </summary>
		/// <param name="company">The company.</param>
		static void DisplayPooledObject(Company company)
		{
			MobilePhone mobilePhone = Pool<MobilePhone>.GetObject();
			mobilePhone.Company = company;

			Console.WriteLine(mobilePhone);
			Pool<MobilePhone>.ReleaseObject(mobilePhone);

			Thread.Sleep(1500);
			_barrier.SignalAndWait();
		}
	}
}
