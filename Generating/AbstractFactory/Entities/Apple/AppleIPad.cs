using AbstractFactory.Abstract;
using AbstractFactory.Entities.Enums;

namespace AbstractFactory.Entities.Apple
{
	public class AppleIPad : ITablet
	{
		/// <summary>
		/// The number of cores.
		/// </summary>
		public int CoresCount => 2;

		/// <summary>
		/// The model of a mouse.
		/// </summary>
		public string Model => "iPad Pro";

		/// <summary>
		/// The current price in US dollars.
		/// </summary>
		public decimal Price => 600;

		/// <summary>
		/// The Vendor.
		/// </summary>
		public Company Vendor => Company.Apple;

		public override string ToString()
		{
			return $"Model: {Model}\nPrice: {Price}\nCores: {CoresCount}\nVendor: {Vendor}\n";
		}
	}
}
