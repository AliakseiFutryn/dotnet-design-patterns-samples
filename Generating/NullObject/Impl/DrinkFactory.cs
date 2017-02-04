using NullObject.Abstract;
using NullObject.Entities;
using NullObject.Entities.Enums;

namespace NullObject.Impl
{
	public static class DrinkFactory
	{
		/// <summary>
		/// Gets the drink from shop.
		/// </summary>
		/// <param name="drinkType">The drink type.</param>
		/// <returns>The drink.</returns>
		public static IDrink GetDrink(DrinkType drinkType)
		{
			switch(drinkType)
			{
				case DrinkType.Cola: return new ColaDrink();
				case DrinkType.Fanta: return new FantaDrink();
				case DrinkType.Sprite: return new SpriteDrink();
				default: return Drink.Null;
			}
		}
	}
}
