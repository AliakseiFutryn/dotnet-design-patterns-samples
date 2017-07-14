using System;
using State.Impl;

namespace State
{
	internal class SampleLauncher
	{
		static void Main(string[] args)
		{
			Transaction transaction = new Transaction();
			
			transaction.StartTransaction();
			Console.WriteLine($"Transaction state: {transaction.TransactionState}");
			
			transaction.SetSum(250);
			Console.WriteLine($"Transaction state: {transaction.TransactionState}");
			
			transaction.SetReceiver("9984-3345-2211-2365-2234");
			Console.WriteLine($"Transaction state: {transaction.TransactionState}");
			
			transaction.CompleteTransaction();
			Console.WriteLine($"Transaction state: {transaction.TransactionState}");

			Console.ReadKey();
		}
	}
}
