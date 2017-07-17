using Decorator.Interfaces;

namespace Decorator.Impl
{
	internal static class MethodRunnerDecoratorProvider
	{
		/// <summary>
		/// Gets the trace method runner decorator.
		/// </summary>
		/// <returns>The trace method runner decorator.</returns>
		public static IMethodRunner GetTraceMethodRunnerDecorator()
		{
			return new TraceMethodRunnerDecorator(new MethodRunner());
		}
	}
}
