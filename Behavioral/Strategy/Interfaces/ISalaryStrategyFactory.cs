namespace Strategy.Interfaces
{
	internal interface ISalaryStrategyFactory
	{
		/// <summary>
		/// Creates the salary strategy.
		/// </summary>
		/// <param name="employee">The employee.</param>
		/// <returns>The salary strategy.</returns>
		ISalaryStrategy CreateSalaryStrategy(IEmployee employee);
	}
}
