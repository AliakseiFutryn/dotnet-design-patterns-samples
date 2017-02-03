using System;
using FactoryMethod.Impl;
using FactoryMethod.Abstract;
using FactoryMethod.Entities.Enums;

namespace FactoryMethod
{
	class SampleLauncher
	{
		static void Main(string[] args)
		{
			foreach(Profession profession in Enum.GetValues(typeof(Profession)))
			{
				DisplaySkills(profession);
			}

			Console.WriteLine("Please enter any key to exit...");
			Console.ReadKey();
		}

		/// <summary>
		/// Displays employee's skills.
		/// </summary>
		/// <param name="profession">The employee's profession.</param>
		static void DisplaySkills(Profession profession)
		{
			Employee employee = LaborExchange.GetEmployee(profession);
			if (employee == null)
			{
				Console.WriteLine("The labor exchange cannot provide any {0}s\n", profession);
				return;
			}

			Console.WriteLine("Profession: {0}", profession);
			employee.DisplaySkills();
		}
	}
}
