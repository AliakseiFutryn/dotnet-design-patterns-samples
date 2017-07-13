using System;

namespace Observer.Entities
{
	internal class TransactionEventArgs : EventArgs
	{
		public TransactionEventArgs(decimal value)
		{
			Value = value;
		}

		/// <summary>
		/// Gets the value.
		/// </summary>
		/// <value>The value.</value>
		public decimal Value { get; }
	}
}
