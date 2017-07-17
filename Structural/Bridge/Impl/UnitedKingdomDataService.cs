using System;
using Bridge.Interfaces;

namespace Bridge.Impl
{
	internal class UnitedKingdomDataService : IDataService
	{
		public string GetCountry()
		{
			return "United Kingdom";
		}

		public DateTime GetLocalTime()
		{
			TimeZoneInfo euTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
			if (euTimeZone == null) throw new TimeZoneNotFoundException("United Kingdom timezone was not found.");

			return TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.Utc, euTimeZone);
		}
	}
}
