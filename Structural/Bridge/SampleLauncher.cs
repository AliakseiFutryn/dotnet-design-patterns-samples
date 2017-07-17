using System;
using Bridge.Impl;

namespace Bridge
{
	internal class SampleLauncher
	{
		static void Main(string[] args)
		{
			CountryInfoProvider countryInfoProvider = new CountryInfoProvider(new GermanyDataService());
			Console.WriteLine(countryInfoProvider);
			
			countryInfoProvider = new CountryInfoProvider(new UnitedKingdomDataService());
			Console.WriteLine(countryInfoProvider);

			Console.ReadKey();
		}
	}
}
