using AbstractFactory.Abstract;
using AbstractFactory.Entities.Enums;

namespace AbstractFactory.Entities.Hp
{
	public class HpEnvy : ILaptop
	{
		/// <summary>
		/// The cpu type.
		/// </summary>
		public CpuType Cpu => CpuType.I7;

		/// <summary>
		/// The model of a mouse.
		/// </summary>
		public string Model => "ENVY Laptop";

		/// <summary>
		/// The current price in US dollars.
		/// </summary>
		public decimal Price => 700;

		/// <summary>
		/// The Vendor.
		/// </summary>
		public Company Vendor => Company.Hp;

		public override string ToString()
		{
			return string.Format("Model: {0}\nPrice: {1}\nCpu: {2}\nVendor: {3}\n", Model, Price, Cpu, Vendor);
		}
	}
}
