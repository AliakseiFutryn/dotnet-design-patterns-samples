using System;
using Interpreter.Impl;
using Interpreter.Entities;

namespace Interpreter
{
	internal class SampleLauncher
	{
		static void Main(string[] args)
		{
			string expression = "one + three - two";
			Evaluator evaluator = new Evaluator(expression);
			int expressionResult = evaluator.Interpret(new Context());

			Console.WriteLine($"The result of expression '{expression}' is {expressionResult}");
			Console.ReadKey();
		}
	}
}
