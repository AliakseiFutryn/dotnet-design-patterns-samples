using System.Collections.Generic;

namespace Interpreter.Entities
{
	internal class Context
	{
		private readonly Dictionary<string, IExpression> _internalContext = new Dictionary<string, IExpression>
		{
			{ "one", new Number(1) },
			{ "two", new Number(2) },
			{ "three", new Number(3) }
		};

		/// <summary>
		/// Gets the <see cref="IExpression"/> with the specified key.
		/// </summary>
		/// <value>The <see cref="IExpression"/>.</value>
		/// <param name="key">The key.</param>
		/// <returns>The internal expression.</returns>
		public IExpression this[string key] => _internalContext[key];
	}
}
