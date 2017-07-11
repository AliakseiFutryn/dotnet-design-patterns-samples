namespace Interpreter.Entities
{
	internal class Number : IExpression
	{
		private readonly int _number;
		
		public Number(int number)
		{
			_number = number;
		}
		
		public int Interpret(Context context)
		{
			return _number;
		}
	}
}
