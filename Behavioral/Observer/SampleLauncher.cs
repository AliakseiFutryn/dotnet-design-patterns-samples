using System;
using Observer.Impl;

namespace Observer
{
	internal class SampleLauncher
	{
		static void Main(string[] args)
		{
			BitcoinExchange bitcoinExchange = new BitcoinExchange();
			MoneyWallet moneyWallet = new MoneyWallet(bitcoinExchange);
			bitcoinExchange.CompleteTransaction(3);

			Console.ReadKey();
		}
	}
}
