namespace Interpreter.Entities
{
	internal interface IExpression
	{
		/// <summary>
		/// Interprets the specified context.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <returns></returns>
		int Interpret(Context context);
	}
}
