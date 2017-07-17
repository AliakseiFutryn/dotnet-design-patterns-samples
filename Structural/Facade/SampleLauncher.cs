using System;
using Facade.Impl;

namespace Facade
{
	internal class SampleLauncher
	{
		static void Main(string[] args)
		{
			PaymentFacade paymentFacade = new PaymentFacade();
			CreditCard creditCard = new CreditCard();
			
			paymentFacade.PayForAll(creditCard, 270, 325, 75);
			paymentFacade.PayForHomeAndCredit(creditCard, 270, 325);
			paymentFacade.PayForHomeAndUniversity(creditCard, 270, 75);
			paymentFacade.PayForCreditAndUniversity(creditCard, 325, 75);

			Console.ReadKey();
		}
	}
}
