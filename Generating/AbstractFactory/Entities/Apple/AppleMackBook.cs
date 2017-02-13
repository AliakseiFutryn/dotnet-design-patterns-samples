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
			return $"Model: {Model}\nPrice: {Price}\nCpu: {Cpu}\nVendor: {Vendor}\n";
		}
	}
}
