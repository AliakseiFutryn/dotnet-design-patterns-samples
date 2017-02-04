using NullObject.Abstract;

namespace NullObject.Entities
{
	internal class NullDrink : Drink
	{
		/// <summary>
		/// The drink name.
		/// </summary>
		public override string Name => "This drink is not available in shop.";

		/// <summary>
		/// The drink's cost in the US dollars.
		/// </summary>
		public override decimal Cost => 0;
	}
}
