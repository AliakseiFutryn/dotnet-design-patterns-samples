using Facade.Interfaces;

namespace Facade.Impl
{
	internal class PaymentFacade
	{
		private readonly IBank _bank;
		
		public PaymentFacade()
		{
			_bank = new Bank();
		}

		/// <summary>
		/// Pays for home and credit.
		/// </summary>
		/// <param name="creditCard">The credit card.</param>
		/// <param name="homePayment">The home payment.</param>
		/// <param name="creditPayment">The credit payment.</param>
		public void PayForHomeAndCredit(ICreditCard creditCard, decimal homePayment, decimal creditPayment)
		{
			_bank.PayForHome(creditCard, homePayment);
			_bank.PayForCredit(creditCard, creditPayment);
		}

		/// <summary>
		/// Pays for home and university.
		/// </summary>
		/// <param name="creditCard">The credit card.</param>
		/// <param name="homePayment">The home payment.</param>
		/// <param name="universityPayment">The university payment.</param>
		public void PayForHomeAndUniversity(ICreditCard creditCard, decimal homePayment, decimal universityPayment)
		{
			_bank.PayForHome(creditCard, homePayment);
			_bank.PayForUniversity(creditCard, universityPayment);
		}

		/// <summary>
		/// Pays for credit and university.
		/// </summary>
		/// <param name="creditCard">The credit card.</param>
		/// <param name="creditPayment">The credit payment.</param>
		/// <param name="universityPayment">The university payment.</param>
		public void PayForCreditAndUniversity(ICreditCard creditCard, decimal creditPayment, decimal universityPayment)
		{
			_bank.PayForCredit(creditCard, creditPayment);
			_bank.PayForUniversity(creditCard, universityPayment);
		}

		/// <summary>
		/// Pays for all.
		/// </summary>
		/// <param name="creditCard">The credit card.</param>
		/// <param name="homePayment">The home payment.</param>
		/// <param name="creditPayment">The credit payment.</param>
		/// <param name="universityPayment">The university payment.</param>
		public void PayForAll(ICreditCard creditCard, decimal homePayment, decimal creditPayment, decimal universityPayment)
		{
			_bank.PayForHome(creditCard, homePayment);
			_bank.PayForCredit(creditCard, creditPayment);
			_bank.PayForUniversity(creditCard, universityPayment);
		}
	}
}
