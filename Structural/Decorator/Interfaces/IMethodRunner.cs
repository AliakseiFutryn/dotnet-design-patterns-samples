using System;

namespace Decorator.Interfaces
{
	internal interface IMethodRunner
	{
		/// <summary>
		/// Runs the method.
		/// </summary>
		/// <param name="action">The action.</param>
		void RunMethod(Action action);
	}
}
