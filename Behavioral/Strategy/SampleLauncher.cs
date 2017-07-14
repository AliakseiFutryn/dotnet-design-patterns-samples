using System;
using Strategy.Impl;
using Strategy.Entities;
using Strategy.Interfaces;

namespace Strategy
{
	internal class SampleLauncher
	{
		static void Main(string[] args)
		{
			SalaryStrategyFactory salaryStrategyFactory = new SalaryStrategyFactory();
			ISalaryStrategy salaryStrategy = salaryStrategyFactory.CreateSalaryStrategy(new SeniorSoftwareEngineer());
			Console.WriteLine($"Senior Software Engineer salary is {salaryStrategy.GetSalary()}");

			salaryStrategy = salaryStrategyFactory.CreateSalaryStrategy(new Director());
			Console.WriteLine($"Director salary is {salaryStrategy.GetSalary()}");

			salaryStrategy = salaryStrategyFactory.CreateSalaryStrategy(new SeniorManager());
			Console.WriteLine($"Senior Manager salary is {salaryStrategy.GetSalary()}");

			Console.ReadKey();
		}
	}
}
