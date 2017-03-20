using Composite.Entities.Interfaces;

namespace Composite.Entities.AffilatedCompanies
{
	public class Next : ICompany
	{
		private const string CompanyName = "Next";

		/// <summary>
		/// Gets the revenue;
		/// </summary>
		/// <returns>The Revenue.</returns>
		public decimal GetRevenue()
		{
			return 2350M;
		}

		/// <summary>
		/// Gets string representation.
		/// </summary>
		/// <returns>String representation.</returns>
		public override string ToString()
		{
			return $"Company: {CompanyName}, Revenue: {GetRevenue()}";
		}
	}
}
