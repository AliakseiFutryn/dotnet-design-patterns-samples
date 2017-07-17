namespace Facade.Interfaces
{
	internal interface ICreditCard
	{
		/// <summary>
		/// Gets the balance.
		/// </summary>
		/// <value>The balance.</value>
		decimal Balance { get; }

		/// <summary>
		/// Gets the card number.
		/// </summary>
		/// <value>The card number.</value>
		string CardNumber { get; }

		/// <summary>
		/// Withdraws the money.
		/// </summary>
		/// <param name="sum">The sum.</param>
		void WithdrawMoney(decimal sum);
	}
}
