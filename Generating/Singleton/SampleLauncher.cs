using System;
using System.Linq;
using System.Threading;
using Singleton.Impl;
using Singleton.Entities;

namespace Singleton
{
	class SampleLauncher
	{
		private const int ThreadsCount = 10;

		static void Main(string[] args)
		{
			// The following method performs a simple check, it creates
			// two instances and they should have a similar reference.
			CheckSingleton(LazySingleton<Meeting>.Instance, LazySingleton<Meeting>.Instance);
			CheckSingleton(DoubleCheckedSingleton<Meeting>.Instance, DoubleCheckedSingleton<Meeting>.Instance);

			// This method deals with multithreading mode and it creates
			// many instances in different threads, then all instances
			// should have a similar reference.
			CheckSingletonInMultithreadingMode();

			Console.WriteLine("Please enter any key to exit...");
			Console.ReadKey();
		}

		static void CheckSingleton(Meeting firstInstance, Meeting secondInstance)
		{
			// The "ParticipantsCount" property should be changed in
			// both instances, as it is a singleton.
			firstInstance.ParticipantsCount++;
			Console.WriteLine("The participants count are equal in both instances of singleton: {0}", firstInstance.ParticipantsCount == secondInstance.ParticipantsCount);
		}

		static void CheckSingletonInMultithreadingMode()
		{
			Thread[] threads = new Thread[ThreadsCount];
			Meeting[] meetings = new Meeting[ThreadsCount];
			EventWaitHandle threadsFinishedEvent = new EventWaitHandle(false, EventResetMode.AutoReset);
			using (Barrier startBarrier = new Barrier(ThreadsCount), finishBarrier = new Barrier(ThreadsCount, (barrier) => threadsFinishedEvent.Set()))
			{
				for (int index = 0; index < ThreadsCount; index++)
				{
					threads[index] = new Thread((threadIndex) =>
					{
						// Synhronizes all threads before start.
						startBarrier.SignalAndWait();
						try
						{
							int currentIdnex = (int)threadIndex;
							meetings[currentIdnex] = currentIdnex >= ThreadsCount / 2 ? DoubleCheckedSingleton<Meeting>.Instance : LazySingleton<Meeting>.Instance;
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.Message);
						}
						finally
						{
							// Synhronizes all threads before finish.
							finishBarrier.SignalAndWait();
						}
					});
					threads[index].Start(index);
				}

				threadsFinishedEvent.WaitOne();
				Meeting lazySingletonInstance = LazySingleton<Meeting>.Instance;
				Meeting doubleCheckedSingletonInstance = DoubleCheckedSingleton<Meeting>.Instance;

				// There is an operation which is responsible for increasing some value of nearly
				// created instances and then it should be compared with all other instances which
				// were created in different threads.
				lazySingletonInstance.ParticipantsCount++;
				doubleCheckedSingletonInstance.ParticipantsCount++;

				Console.WriteLine("[Multithreading] The participants count are equal in all instances of LazySingleton: {0}", meetings.Take(10).All(m => m.ParticipantsCount == lazySingletonInstance.ParticipantsCount));
				Console.WriteLine("[Multithreading] The participants count are equal in all instances of DoubleCheckedSingleton: {0}", meetings.Skip(10).All(m => m.ParticipantsCount == lazySingletonInstance.ParticipantsCount));
			}
		}
	}
}
