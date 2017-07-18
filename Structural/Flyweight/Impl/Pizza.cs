using System;
using Flyweight.Interfaces;

namespace Flyweight.Impl
{
	internal class Pizza : IPizzaOrder
	{
		private readonly string _pizzaName;

		public Pizza(string pizzaName)
		{
			_pizzaName = pizzaName;
		}

		public void Deliver(string address)
		{
			Console.WriteLine($"The pizza {_pizzaName} was delivered to {address}. Bon appetit!");
		}
	}
}
