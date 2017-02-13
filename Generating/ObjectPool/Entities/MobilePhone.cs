using System;
using System.Runtime.InteropServices;
using ObjectPool.Entities.Enums;

namespace ObjectPool.Entities
{
	public class MobilePhone
	{
		private decimal _initialPrice = 100;
		private DateTime _creationTime;

		public MobilePhone()
		{
			_creationTime = DateTime.UtcNow;
		}

		/// <summary>
		/// The model of mobile phone.
		/// </summary>
		public Company Company { get; set; }

		/// <summary>
		/// Gets the string representation.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{ 
			return $"Company: {Company}\nPrice:{CalculatePrice()}\nCreational time: {_creationTime.ToLongTimeString()}\n";
		}

		/// <summary>
		/// Calculates the price of the phone.
		/// </summary>
		/// <returns>The price.</returns>
		private decimal CalculatePrice()
		{
			switch(Company)
			{
				case Company.Apple: return _initialPrice * 5;
				case Company.Microsoft: return _initialPrice * 4;
				case Company.Google: return _initialPrice * 3;
				default: return _initialPrice;
			}
		}
	}
}
