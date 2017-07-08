using Command.Interfaces;

namespace Command.Impl
{
	internal class CalculatorCommand : ICommand
	{
		private readonly int _operand;
		private readonly char _operator;
		private readonly Calculator _calculator;

		public CalculatorCommand(int operand, char @operator, Calculator calculator)
		{
			_operand = operand;
			_operator = @operator;
			_calculator = calculator;
		}

		public void Execute()
		{
			_calculator.Operation(_operator, _operand);
		}

		public void UnExecute()
		{
			_calculator.Operation(Undo(_operator), _operand);
		}

		#region Private methods

		private char Undo(char @operator)
		{
			char undo = ' ';
			switch (@operator)
			{
				case '+': undo = '-'; break;
				case '-': undo = '+'; break;
				case '*': undo = '/'; break;
				case '/': undo = '*'; break;
			}

			return undo;
		}
		
		#endregion
	}
}
