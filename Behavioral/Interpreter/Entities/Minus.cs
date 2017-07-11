namespace Interpreter.Entities
{
	internal class Minus : IExpression
	{
		private readonly IExpression _leftOperand;
		private readonly IExpression _rightOperand;

		public Minus(IExpression leftOperand,
					 IExpression rightOperand)
		{
			_leftOperand = leftOperand;
			_rightOperand = rightOperand;
		}
			
		public int Interpret(Context context)
		{
			return _leftOperand.Interpret(context) - _rightOperand.Interpret(context);
		}
	}
}
