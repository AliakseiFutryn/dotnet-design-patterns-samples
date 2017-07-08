using System;

namespace Command.Impl
{
	internal class Calculator
	{
		private int _currentValue = 0;

		/// <summary>
		/// This method is responsible for calculating
		/// the result and displaying it.
		/// </summary>
		/// <param name="operator">The math operator like minus or plus.</param>
		/// <param name="operand">The operand.</param>
		public void Operation(char @operator, int operand)
		{
			int oldValue = _currentValue;
			
			switch (@operator)
			{
				case '+': _currentValue += operand; break;
				case '-': _currentValue -= operand; break;
				case '*': _currentValue *= operand; break;
				case '/': _currentValue /= operand; break;
			}
			Console.WriteLine($"Operation: {oldValue} {@operator} {operand} = {_currentValue}");
		}
	}
}
