using System.Collections.Generic;
using Composite.Entities.Interfaces;
using Composite.Entities.AffilatedCompanies;

namespace Composite.Entities
{
	public class Alphabet : Company
	{
		private const string CompanyName = "Alphabet";

		public Alphabet()
		{
			AffilatedCompanies.AddRange(new List<ICompany>
			{
				new Google(),
				new FameBit()
			});
		}

		/// <summary>
		/// Gets the company information.
		/// </summary>
		/// <returns>Company information.</returns>
		public override string ToString()
		{
			return $"\n{CompanyName} revenue is {GetRevenue()}\nAffilated companies:\n{string.Join("\n", AffilatedCompanies)}";
		}
	}
}
