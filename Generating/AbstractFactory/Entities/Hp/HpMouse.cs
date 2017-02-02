using AbstractFactory.Abstract;
using AbstractFactory.Entities.Enums;

namespace AbstractFactory.Entities.Hp
{
	public class HpMouse : IMouse
	{
		/// <summary>
		/// The model of a mouse.
		/// </summary>
		public string Model => "X3000 Wireless Mouse";

		/// <summary>
		/// The current price in US dollars.
		/// </summary>
		public decimal Price => 30;

		/// <summary>
		/// The type of mouse.
		/// </summary>
		public MouseType Type => MouseType.Pc;

		/// <summary>
		/// The Vendor.
		/// </summary>
		public Company Vendor => Company.Hp;

		public override string ToString()
		{
			return string.Format("Model: {0}\nPrice: {1}\nType: {2}\nVendor: {3}\n", Model, Price, Type, Vendor);
		}
	}
}
