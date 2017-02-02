using AbstractFactory.Abstract;
using AbstractFactory.Entities.Enums;

namespace AbstractFactory.Entities.Apple
{
	public class AppleMackBook : ILaptop
	{
		/// <summary>
		/// The cpu type.
		/// </summary>
		public CpuType Cpu => CpuType.I5;

		/// <summary>
		/// The model of a mouse.
		/// </summary>
		public string Model => "MacBook Pro";

		/// <summary>
		/// The current price in US dollars.
		/// </summary>
		public decimal Price => 1500;

		/// <summary>
		/// The Vendor.
		/// </summary>
		public Company Vendor => Company.Apple;

		public override string ToString()
		{
			return string.Format("Model: {0}\nPrice: {1}\nCpu: {2}\nVendor: {3}\n", Model, Price, Cpu, Vendor);
		}
	}
}
