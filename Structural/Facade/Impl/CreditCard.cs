using System;
using Facade.Interfaces;

namespace Facade.Impl
{
	internal class CreditCard : ICreditCard
	{
		public CreditCard()
		{
			Random random = new Random(DateTime.UtcNow.Millisecond);
			Balance = random.Next(1, 9999);
		}

		public decimal Balance { get; private set; }

		public string CardNumber => "9899-0098-7877-8899-2344";
		
		public void WithdrawMoney(decimal sum)
		{
			Balance -= sum;
		}
	}
}
