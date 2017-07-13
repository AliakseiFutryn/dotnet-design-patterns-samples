using System;
using State.Impl;
using State.Interfaces;
using State.Properties;

namespace State.Entities
{
	internal class ReceiverTransactionState : ITransactionState
	{
		private readonly Transaction _transaction;

		public ReceiverTransactionState(Transaction transaction)
		{
			_transaction = transaction;
		}

		public void StartTransaction()
		{
			Console.WriteLine(Resources.StartTransactionErrorMessage);
		}

		public void SetReceiver(string wallet)
		{
			if (_transaction.TransactionState == TransactionState.ReceiverState)
			{
				_transaction.SetState(TransactionState.CompleteTransactionState);
				_transaction.ReceiverWallet = wallet;
				Console.WriteLine("The receiver was set.");
			}
			else Console.WriteLine(Resources.ReceiverErrorMessage);
		}

		public void SetSum(decimal sum)
		{
			Console.WriteLine(Resources.SumErrorMessage);
		}

		public bool CompleteTransaction()
		{
			Console.WriteLine(Resources.CompleteTransactionErrorMessage);
			return false;
		}
	}
}
