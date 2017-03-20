using System.Linq;
using System.Collections.Generic;

namespace Composite.Entities.Interfaces
{
	public abstract class Company : ICompany
	{
		private readonly List<ICompany> _affilatedCompanies;

		protected Company()
		{
			_affilatedCompanies = new List<ICompany>();
		}
		
		/// <summary>
		/// Gets the affilated companies.
		/// </summary>
		public List<ICompany> AffilatedCompanies => _affilatedCompanies;

		/// <summary>
		/// Gets the revenue.
		/// </summary>
		/// <returns>The revenue.</returns>
		public decimal GetRevenue()
		{
			return _affilatedCompanies.Sum(company => company.GetRevenue());
		}
	}
}
