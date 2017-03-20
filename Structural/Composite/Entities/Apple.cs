using System.Collections.Generic;
using Composite.Entities.Interfaces;
using Composite.Entities.AffilatedCompanies;

namespace Composite.Entities
{
	public class Apple : Company
	{
		private const string CompanyName = "Apple";

		public Apple()
		{
			AffilatedCompanies.AddRange(new List<ICompany>
			{
				new Next(),
				new PowerSchool()
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
