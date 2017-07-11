namespace Interpreter.Entities
{
	internal class Plus : IExpression
	{
		private readonly IExpression _leftOperand;
		private readonly IExpression _rightOperand;

		public Plus(IExpression leftOperand,
					IExpression rightOperand)
		{
			_leftOperand = leftOperand;
			_rightOperand = rightOperand;
		}

		public int Interpret(Context context)
		{
			return _leftOperand.Interpret(context) + _rightOperand.Interpret(context);
		}
	}
}
