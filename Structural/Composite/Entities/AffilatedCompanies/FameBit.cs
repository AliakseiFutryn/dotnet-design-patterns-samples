using Composite.Entities.Interfaces;

namespace Composite.Entities.AffilatedCompanies
{
	public class FameBit : ICompany
	{
		private const string CompanyName = "FameBit";

		/// <summary>
		/// Gets the revenue;
		/// </summary>
		/// <returns>The Revenue.</returns>
		public decimal GetRevenue()
		{
			return 50M;
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
