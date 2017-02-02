using AbstractFactory.Abstract;
using AbstractFactory.Entities.Enums;

namespace AbstractFactory.Entities.Microsoft
{
	public class MicrosoftSurfacePro : ITablet
	{
		/// <summary>
		/// The number of cores.
		/// </summary>
		public int CoresCount => 2;

		/// <summary>
		/// The model of a mouse.
		/// </summary>
		public string Model => "Surface Pro 4";

		/// <summary>
		/// The current price in US dollars.
		/// </summary>
		public decimal Price => 1800;

		/// <summary>
		/// The Vendor.
		/// </summary>
		public Company Vendor => Company.Microsoft;

		public override string ToString()
		{
			return string.Format("Model: {0}\nPrice: {1}\nCores: {2}\nVendor: {3}\n", Model, Price, CoresCount, Vendor);
		}
	}
}
