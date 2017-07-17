using System;
using System.Diagnostics;
using Decorator.Interfaces;

namespace Decorator.Impl
{
	internal class TraceMethodRunnerDecorator : MethodRunnerDecorator
	{
		public TraceMethodRunnerDecorator(IMethodRunner methodRunner) : base(methodRunner) {}

		public override void RunMethod(Action action)
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			MethodRunner.RunMethod(action);
			stopwatch.Stop();
			Console.WriteLine($"The action was completed after {stopwatch.ElapsedMilliseconds} milliseconds.");
		}
	}
}
