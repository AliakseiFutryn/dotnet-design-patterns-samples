namespace State.Interfaces
{
	internal interface ITransactionState
	{
		/// <summary>
		/// Starts the transaction.
		/// </summary>
		void StartTransaction();

		/// <summary>
		/// Sets the receiver.
		/// </summary>
		/// <param name="wallet">The wallet.</param>
		void SetReceiver(string wallet);

		/// <summary>
		/// Sets the sum.
		/// </summary>
		/// <param name="sum">The sum.</param>
		void SetSum(decimal sum);

		/// <summary>
		/// Completes the transaction.
		/// </summary>
		/// <returns>The result of transaction.</returns>
		bool CompleteTransaction();
	}
}
