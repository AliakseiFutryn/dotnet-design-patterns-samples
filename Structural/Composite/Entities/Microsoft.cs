using System.Collections.Generic;
using Composite.Entities.Interfaces;
using Composite.Entities.AffilatedCompanies;

namespace Composite.Entities
{
	public class Microsoft : Company
	{
		private const string CompanyName = "Microsoft";

		public Microsoft()
		{
			AffilatedCompanies.AddRange(new List<ICompany>
			{
				new Xamarin(),
				new LinkedIn()
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
