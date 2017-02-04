using NullObject.Abstract;

namespace NullObject.Entities
{
	public class ColaDrink : Drink
	{
		/// <summary>
		/// The drink name.
		/// </summary>
		public override string Name => "Coca-Cola";

		/// <summary>
		/// The drink's cost in the US dollars.
		/// </summary>
		public override decimal Cost => 3;
	}
}
