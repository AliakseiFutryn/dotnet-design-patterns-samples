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
			transaction.SetSum(250);
			transaction.SetReceiver("9984-3345-2211-2365-2234");
			transaction.CompleteTransaction();

			Console.ReadKey();
		}
	}
}
