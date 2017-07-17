using System;
using Decorator.Interfaces;

namespace Decorator.Impl
{
	internal class MethodRunner : IMethodRunner
	{
		public void RunMethod(Action action)
		{
			try
			{
				action();
				Console.WriteLine("Method was run successfully.");
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
