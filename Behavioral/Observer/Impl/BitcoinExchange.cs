using System;
using Observer.Entities;

namespace Observer.Impl
{
	internal class BitcoinExchange
	{
		public void CompleteTransaction(decimal sum)
		{
			TransactionCompleted?.Invoke(this, new TransactionEventArgs(sum));
		}
		
		#region Event handlers

		private event EventHandler<TransactionEventArgs> TransactionCompleted;

		/// <summary>
		/// Occurs when [on transactopn completed].
		/// </summary>
		public event EventHandler<TransactionEventArgs> OnTransactionCompleted
		{
			add => TransactionCompleted += value;
			remove
			{
				if (TransactionCompleted != null) TransactionCompleted -= value;
			}
		}

		#endregion
	}
}
