using AbstractFactory.Abstract;
using AbstractFactory.Entities.Enums;

namespace AbstractFactory.Entities.Apple
{
	public class AppleMouse : IMouse
	{
		/// <summary>
		/// The model of a mouse.
		/// </summary>
		public string Model => "Apple Magic Mouse";

		/// <summary>
		/// The current price in US dollars.
		/// </summary>
		public decimal Price => 100;

		/// <summary>
		/// The type of mouse.
		/// </summary>
		public MouseType Type => MouseType.Pc;

		/// <summary>
		/// The Vendor.
		/// </summary>
		public Company Vendor => Company.Apple;

		public override string ToString()
		{
			return $"Model: {Model}\nPrice: {Price}\nType: {Type}\nVendor: {Vendor}\n";
		}
	}
}
