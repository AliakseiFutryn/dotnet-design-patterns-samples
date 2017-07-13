using System;
using State.Impl;
using State.Interfaces;
using State.Properties;

namespace State.Entities
{
	internal class SumTransactionState : ITransactionState
	{
		private readonly Transaction _transaction;

		public SumTransactionState(Transaction transaction)
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
			if (_transaction.TransactionState == TransactionState.SumState)
			{
				_transaction.SetState(TransactionState.ReceiverState);
				_transaction.TransactionSum = sum;
				Console.WriteLine("The sum was set.");
			}
			else Console.WriteLine(Resources.SumErrorMessage);
		}

		public bool CompleteTransaction()
		{
			Console.WriteLine(Resources.CompleteTransactionErrorMessage);
			return false;
		}
	}
}
