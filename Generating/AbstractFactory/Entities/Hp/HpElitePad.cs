using AbstractFactory.Abstract;
using AbstractFactory.Entities.Enums;

namespace AbstractFactory.Entities.Hp
{
	public class HpElitePad : ITablet
	{
		/// <summary>
		/// The number of cores.
		/// </summary>
		public int CoresCount => 4;

		/// <summary>
		/// The model of a mouse.
		/// </summary>
		public string Model => "ElitePad 1000 G2";

		/// <summary>
		/// The current price in US dollars.
		/// </summary>
		public decimal Price => 1000;

		/// <summary>
		/// The Vendor.
		/// </summary>
		public Company Vendor => Company.Hp;

		public override string ToString()
		{
			return string.Format("Model: {0}\nPrice: {1}\nCores: {2}\nVendor: {3}\n", Model, Price, CoresCount, Vendor);
		}
	}
}
