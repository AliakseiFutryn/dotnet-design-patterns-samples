using Strategy.Interfaces;

namespace Strategy.Impl
{
	internal class SalaryStrategyFactory : ISalaryStrategyFactory
	{
		public ISalaryStrategy CreateSalaryStrategy(IEmployee employee)
		{
			switch (employee.Title)
			{
				case "Director": return new DirectorSalaryStrategy();
				case "Senior Manager": return new SeniorManagerSalaryStrategy();
				case "Senior Software Engineer": return new SeniorSoftwareEngineerSalaryStrategy();
				default: return null;
			}
		}
	}
}
