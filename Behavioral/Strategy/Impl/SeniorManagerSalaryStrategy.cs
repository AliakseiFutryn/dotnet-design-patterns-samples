using Strategy.Interfaces;

namespace Strategy.Impl
{
	internal class SeniorManagerSalaryStrategy : ISalaryStrategy
	{
		private readonly decimal _currentSalary = 80000;
		
		public decimal GetSalary()
		{
			return _currentSalary;
		}
	}
}
