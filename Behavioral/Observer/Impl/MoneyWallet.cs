using System;
using Observer.Entities;

namespace Observer.Impl
{
	internal class MoneyWallet : IDisposable
	{
		private const decimal ExchangeRate = 2700;
		private BitcoinExchange _bitcoinExchange;
		private decimal _currentBalance;
		
		public MoneyWallet(BitcoinExchange bitcoinExchange)
		{
			_bitcoinExchange = bitcoinExchange;
			_bitcoinExchange.OnTransactionCompleted += OnOnTransactionCompleted;
		}

		private void OnOnTransactionCompleted(object sender, TransactionEventArgs transactionEventArgs)
		{
			Console.WriteLine($"Current exchange rate is {ExchangeRate}");
			Console.WriteLine($"You've got {transactionEventArgs.Value} BTC");

			_currentBalance = transactionEventArgs.Value * ExchangeRate;
			Console.WriteLine($"Your current balance is {_currentBalance}");
		}

		#region Disposable pattern

		private bool _disposed;

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			if (!_disposed)
			{
				_bitcoinExchange.OnTransactionCompleted -= OnOnTransactionCompleted;
				_bitcoinExchange = null;
				_disposed = true;
			}
		}

		#endregion
	}
}
