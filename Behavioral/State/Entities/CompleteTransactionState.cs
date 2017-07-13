using System;
using State.Impl;
using State.Interfaces;
using State.Properties;

namespace State.Entities
{
	internal class CompleteTransactionState : ITransactionState
	{
		private readonly Transaction _transaction;

		public CompleteTransactionState(Transaction transaction)
		{
			_transaction = transaction;
		}

		public void StartTransaction()
		{
			Console.WriteLine(Resources.StartTransactionErrorMessage);
		}

		public void SetReceiver(string wallet)
		{
			Console.WriteLine(Resources.ReceiverErrorMessage);
		}

		public void SetSum(decimal sum)
		{
			Console.WriteLine(Resources.SumErrorMessage);
		}

		public bool CompleteTransaction()
		{
			if (_transaction.TransactionState == TransactionState.CompleteTransactionState)
			{
				Console.WriteLine($"Transaction of {_transaction.TransactionSum}$ to {_transaction.ReceiverWallet} was completed.");
				_transaction.SetState(TransactionState.None);
				return true;
			}
			Console.WriteLine(Resources.CompleteTransactionErrorMessage);
			return false;
		}
	}
}
