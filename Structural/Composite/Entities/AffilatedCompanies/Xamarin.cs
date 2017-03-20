using Composite.Entities.Interfaces;

namespace Composite.Entities.AffilatedCompanies
{
	public class Xamarin : ICompany
	{
		private const string CompanyName = "Xamarin";

		/// <summary>
		/// Gets the revenue;
		/// </summary>
		/// <returns>The Revenue.</returns>
		public decimal GetRevenue()
		{
			return 150M;
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
