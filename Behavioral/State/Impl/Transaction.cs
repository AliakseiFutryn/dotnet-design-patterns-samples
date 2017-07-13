using State.Entities;
using State.Interfaces;

namespace State.Impl
{
	internal class Transaction : ITransaction
	{
		private ITransactionState _currentState;
		private TransactionState _transactionState;
		
		private readonly ITransactionState _sumState;
		private readonly ITransactionState _receiverState;
		private readonly ITransactionState _startTransactionState;
		private readonly ITransactionState _completeTransactionState;

		public Transaction()
		{
			_sumState = new SumTransactionState(this);
			_receiverState = new ReceiverTransactionState(this);
			_startTransactionState = new StartTransactionState(this);
			_completeTransactionState = new CompleteTransactionState(this);

			_currentState = _startTransactionState;
			_transactionState = TransactionState.None;
		}
		
		public void StartTransaction()
		{
			_currentState.StartTransaction();
		}

		public void SetReceiver(string wallet)
		{
			_currentState.SetReceiver(wallet);
		}

		public void SetSum(decimal sum)
		{
			_currentState.SetSum(sum);
		}

		public bool CompleteTransaction()
		{
			return _currentState.CompleteTransaction();
		}

		internal void SetState(TransactionState state)
		{
			_transactionState = state;
			switch (state)
			{
				case TransactionState.None: _currentState = null; break;
				case TransactionState.SumState: _currentState = _sumState; break;
				case TransactionState.ReceiverState: _currentState = _receiverState; break;
				case TransactionState.StartTransactionState: _currentState = _startTransactionState; break;
				case TransactionState.CompleteTransactionState: _currentState = _completeTransactionState; break;
			}
		}

		public ITransactionState GetSumState()
		{
			return _sumState;
		}

		public ITransactionState GetReceiverState()
		{
			return _receiverState;
		}

		public ITransactionState GetStartTransactionState()
		{
			return _startTransactionState;
		}

		public ITransactionState GetCompleteTransactionState()
		{
			return _completeTransactionState;
		}

		#region Properties

		public string ReceiverWallet { get; set; }

		public decimal TransactionSum { get; set; }

		public bool TransactionStarted { get; set; }

		public bool TransactionCompleted { get; set; }

		internal TransactionState TransactionState => _transactionState;

		#endregion
	}
}
