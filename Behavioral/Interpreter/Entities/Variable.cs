namespace Interpreter.Entities
{
	internal class Variable : IExpression
	{
		private readonly string _name;

		public Variable(string name)
		{
			_name = name;
		}

		public int Interpret(Context context)
		{
			return string.IsNullOrEmpty(_name) ? 0 : context[_name].Interpret(context);
		}
	}
}
