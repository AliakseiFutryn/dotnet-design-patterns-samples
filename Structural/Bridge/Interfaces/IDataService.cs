using System;

namespace Bridge.Interfaces
{
	internal interface IDataService
	{
		/// <summary>
		/// Gets the country.
		/// </summary>
		/// <returns>The country.</returns>
		string GetCountry();

		/// <summary>
		/// Gets the local time.
		/// </summary>
		/// <returns>The local time.</returns>
		DateTime GetLocalTime();
	}
}
