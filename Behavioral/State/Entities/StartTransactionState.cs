using System;
using State.Impl;
using State.Interfaces;
using State.Properties;

namespace State.Entities
{
	internal class StartTransactionState : ITransactionState
	{
		private readonly Transaction _transaction;
		
		public StartTransactionState(Transaction transaction)
		{
			_transaction = transaction;
		}
		
		public void StartTransaction()
		{
			if (_transaction.TransactionState == TransactionState.None)
			{
				Console.WriteLine("Transaction started.");
				_transaction.SetState(TransactionState.SumState);
			}
			else Console.WriteLine(Resources.StartTransactionErrorMessage);
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
			Console.WriteLine(Resources.CompleteTransactionErrorMessage);
			return false;
		}
	}
}
