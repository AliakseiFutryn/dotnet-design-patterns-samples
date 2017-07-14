namespace Strategy.Interfaces
{
	internal interface ISalaryStrategy
	{
		/// <summary>
		/// Gets the salary.
		/// </summary>
		/// <returns>The salary of employee.</returns>
		decimal GetSalary();
	}
}
