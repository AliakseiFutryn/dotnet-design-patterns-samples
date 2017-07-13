namespace State.Interfaces
{
	internal interface ITransaction : ITransactionState
	{
		/// <summary>
		/// Gets or sets the receiver wallet.
		/// </summary>
		/// <value>The receiver wallet.</value>
		string ReceiverWallet { get; set; }

		/// <summary>
		/// Gets or sets the transaction sum.
		/// </summary>
		/// <value>The transaction sum.</value>
		decimal TransactionSum { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [transaction started].
		/// </summary>
		/// <value>
		///   <c>true</c> if [transaction started]; otherwise, <c>false</c>.
		/// </value>
		bool TransactionStarted { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [transaction completed].
		/// </summary>
		/// <value>
		///   <c>true</c> if [transaction completed]; otherwise, <c>false</c>.
		/// </value>
		bool TransactionCompleted { get; set; }
		
		/// <summary>
		/// Gets the state of the sum.
		/// </summary>
		/// <returns>The transaction state.</returns>
		ITransactionState GetSumState();

		/// <summary>
		/// Gets the state of the receiver.
		/// </summary>
		/// <returns>The transaction state.</returns>
		ITransactionState GetReceiverState();

		/// <summary>
		/// Gets the start state of the transaction.
		/// </summary>
		/// <returns>The transaction state.</returns>
		ITransactionState GetStartTransactionState();

		/// <summary>
		/// Gets the state of the complete transaction.
		/// </summary>
		/// <returns>The transaction state.</returns>
		ITransactionState GetCompleteTransactionState();
	}
}
