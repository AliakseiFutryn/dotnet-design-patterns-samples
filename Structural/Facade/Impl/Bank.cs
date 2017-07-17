using System;
using Facade.Interfaces;

namespace Facade.Impl
{
	internal class Bank : IBank
	{
		private const string PaymentMessagePattern = "The payment was successful, {0}$ was withdrawn from {1} card. Your balance is {2}.";
		private const string ErrorMessagePattern = "Unfortunately, you do not have {0}$ on your {1} card. Your balance is {2}.";

		public void PayForHome(ICreditCard creditCard, decimal homeTaxes)
		{
			string message;
			if (creditCard.Balance >= homeTaxes)
			{
				creditCard.WithdrawMoney(homeTaxes);
				message = string.Format(PaymentMessagePattern, homeTaxes, creditCard.CardNumber, creditCard.Balance);
			}
			else message = string.Format(ErrorMessagePattern, homeTaxes, creditCard.CardNumber, creditCard.Balance);

			Console.WriteLine(message);
		}

		public void PayForCredit(ICreditCard creditCard, decimal creditTaxes)
		{
			string message;
			if (creditCard.Balance >= creditTaxes)
			{
				creditCard.WithdrawMoney(creditTaxes);
				message = string.Format(PaymentMessagePattern, creditTaxes, creditCard.CardNumber, creditCard.Balance);
			}
			else message = string.Format(ErrorMessagePattern, creditTaxes, creditCard.CardNumber, creditCard.Balance);

			Console.WriteLine(message);
		}

		public void PayForUniversity(ICreditCard creditCard, decimal universityTaxes)
		{
			string message;
			if (creditCard.Balance >= universityTaxes)
			{
				creditCard.WithdrawMoney(universityTaxes);
				message = string.Format(PaymentMessagePattern, universityTaxes, creditCard.CardNumber, creditCard.Balance);
			}
			else message = string.Format(ErrorMessagePattern, universityTaxes, creditCard.CardNumber, creditCard.Balance);

			Console.WriteLine(message);
		}
	}
}
