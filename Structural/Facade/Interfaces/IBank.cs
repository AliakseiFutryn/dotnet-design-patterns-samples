namespace Facade.Interfaces
{
	internal interface IBank
	{
		/// <summary>
		/// Pays for home.
		/// </summary>
		/// <param name="creditCard">The credit card.</param>
		/// <param name="homeTaxes">The home taxes.</param>
		void PayForHome(ICreditCard creditCard, decimal homeTaxes);

		/// <summary>
		/// Pays for credit.
		/// </summary>
		/// <param name="creditCard">The credit card.</param>
		/// <param name="creditTaxes">The credit taxes.</param>
		void PayForCredit(ICreditCard creditCard, decimal creditTaxes);

		/// <summary>
		/// Pays for university.
		/// </summary>
		/// <param name="creditCard">The credit card.</param>
		/// <param name="universityTaxes">The university taxes.</param>
		void PayForUniversity(ICreditCard creditCard, decimal universityTaxes);
	}
}
