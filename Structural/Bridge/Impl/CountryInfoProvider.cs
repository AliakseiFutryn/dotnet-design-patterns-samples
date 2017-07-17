using System;
using Bridge.Interfaces;

namespace Bridge.Impl
{
	internal class CountryInfoProvider : ICountryInfoProvider
	{
		private readonly IDataService _dataService;
		
		public CountryInfoProvider(IDataService dataService)
		{
			_dataService = dataService;
		}
		
		public string GetCountry()
		{
			return _dataService.GetCountry();
		}

		public DateTime GetLocalTime()
		{
			return _dataService.GetLocalTime();
		}

		/// <summary>
		/// Returns a <see cref="string" /> that represents this instance.
		/// </summary>
		/// <returns>A <see cref="string" /> that represents this instance.</returns>
		public override string ToString()
		{
			return $"The local time in {GetCountry()} is {GetLocalTime():T}";
		}
	}
}
