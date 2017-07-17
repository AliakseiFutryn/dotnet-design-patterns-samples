using System;
using Bridge.Interfaces;

namespace Bridge.Impl
{
	internal class GermanyDataService : IDataService
	{
		public string GetCountry()
		{
			return "Germany";
		}

		public DateTime GetLocalTime()
		{
			TimeZoneInfo euTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
			if (euTimeZone == null) throw new TimeZoneNotFoundException("Germany timezone was not found.");

			return TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.Utc, euTimeZone);
		}
	}
}
