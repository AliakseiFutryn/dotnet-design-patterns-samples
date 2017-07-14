using Strategy.Interfaces;

namespace Strategy.Impl
{
	internal class SeniorSoftwareEngineerSalaryStrategy : ISalaryStrategy
	{
		private readonly decimal _currentSalary = 70000;
		
		public decimal GetSalary()
		{
			return _currentSalary;
		}
	}
}
