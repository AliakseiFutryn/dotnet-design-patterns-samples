using NullObject.Abstract;

namespace NullObject.Entities
{
	public class FantaDrink : Drink
	{
		/// <summary>
		/// The drink name.
		/// </summary>
		public override string Name => "Fanta";

		/// <summary>
		/// The drink's cost in the US dollars.
		/// </summary>
		public override decimal Cost => 2;
	}
}
