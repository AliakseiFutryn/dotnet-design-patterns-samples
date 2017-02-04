using System;
using NullObject.Impl;
using NullObject.Abstract;
using NullObject.Entities.Enums;

namespace NullObject
{
	class SampleLauncher
	{
		static void Main(string[] args)
		{
			IDrink drink = DrinkFactory.GetDrink(DrinkType.Cola);
			Console.WriteLine(drink);

			drink = DrinkFactory.GetDrink(DrinkType.Fanta);
			Console.WriteLine(drink);

			// Tries to get drink which is not available in shop,
			// as a result receives NullObject.
			drink = DrinkFactory.GetDrink(DrinkType.Pepsi);
			Console.WriteLine(drink);

			drink = DrinkFactory.GetDrink(DrinkType.Sprite);
			Console.WriteLine(drink);

			Console.WriteLine("Please enter any key to exit...");
			Console.ReadKey();
		}
	}
}
