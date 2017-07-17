using System;
using System.Threading;
using Decorator.Impl;
using Decorator.Interfaces;

namespace Decorator
{
	internal class SampleLauncher
	{
		static void Main(string[] args)
		{
			IMethodRunner methodRunner = MethodRunnerDecoratorProvider.GetTraceMethodRunnerDecorator();
			methodRunner.RunMethod(() => Thread.Sleep(1500));

			Console.ReadKey();
		}
	}
}
