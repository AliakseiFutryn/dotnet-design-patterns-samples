using System;
using Decorator.Interfaces;

namespace Decorator.Impl
{
	internal abstract class MethodRunnerDecorator : IMethodRunner
	{
		protected readonly IMethodRunner MethodRunner;
		
		internal MethodRunnerDecorator(IMethodRunner methodRunner)
		{
			MethodRunner = methodRunner;
		}

		public abstract void RunMethod(Action action);
	}
}
