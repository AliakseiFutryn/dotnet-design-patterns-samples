using AbstractFactory.Abstract;
using AbstractFactory.Entities.Enums;

namespace AbstractFactory.Entities.Microsoft
{
	public class MicrosoftSurfaceBook : ILaptop
	{
		/// <summary>
		/// The cpu type.
		/// </summary>
		public CpuType Cpu => CpuType.I5;

		/// <summary>
		/// The model of a mouse.
		/// </summary>
		public string Model => "Surface Book";

		/// <summary>
		/// The current price in US dollars.
		/// </summary>
		public decimal Price => 1500;

		/// <summary>
		/// The Vendor.
		/// </summary>
		public Company Vendor => Company.Microsoft;

		public override string ToString()
		{
			return string.Format("Model: {0}\nPrice: {1}\nCpu: {2}\nVendor: {3}\n", Model, Price, Cpu, Vendor);
		}
	}
}
