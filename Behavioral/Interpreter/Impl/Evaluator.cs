using System.Collections.Generic;
using Interpreter.Entities;

namespace Interpreter.Impl
{
	internal class Evaluator : IExpression
	{
		private readonly IExpression _expressionTree;

		public Evaluator(string expression)
		{
			if (!string.IsNullOrEmpty(expression))
			{
				string[] tokens = expression.Split(' ');
				Stack<IExpression> stack = new Stack<IExpression>();
				for(int currentTokenIndex = 0; currentTokenIndex < tokens.Length; currentTokenIndex++)
				{
					string currentToken = tokens[currentTokenIndex];
					switch (currentToken)
					{
						case "one":
						case "two":
						case "three": stack.Push(new Variable(currentToken)); break;
						case "-":
						{
							if (currentTokenIndex + 1 < tokens.Length)
							{
								stack.Push(new Minus(stack.Pop(), new Variable(tokens[currentTokenIndex + 1])));
								currentTokenIndex++;
							}
							break;
						}
						case "+":
						{
							if (currentTokenIndex + 1 < tokens.Length)
							{
								stack.Push(new Plus(stack.Pop(), new Variable(tokens[currentTokenIndex + 1])));
								currentTokenIndex++;
							}
							break;
						}
					}
				}

				_expressionTree = stack.Pop();
			}
		}
		
		public int Interpret(Context context)
		{
			return _expressionTree.Interpret(context);
		}
	}
}
