using System;
using System.Collections.Generic;
using Flyweight.Interfaces;

namespace Flyweight.Impl
{
	internal class Restaurant
	{
		private readonly PizzaFactory _pizzaFactory;
		private readonly List<KeyValuePair<IPizzaOrder, PizzaOrderContext>> _pizzas;
		
		public Restaurant()
		{
			_pizzaFactory = new PizzaFactory();
			_pizzas = new List<KeyValuePair<IPizzaOrder, PizzaOrderContext>>();
		}

		/// <summary>
		/// Takes the order.
		/// </summary>
		/// <param name="pizzaName">Name of the pizza.</param>
		/// <param name="address">The address.</param>
		public void TakeOrder(string pizzaName, string address)
		{
			IPizzaOrder pizza = _pizzaFactory.GetPizza(pizzaName);
			_pizzas.Add(new KeyValuePair<IPizzaOrder, PizzaOrderContext>(pizza, new PizzaOrderContext(address)));
		}

		/// <summary>
		/// Delivers this instance.
		/// </summary>
		public void Deliver()
		{
			foreach (KeyValuePair<IPizzaOrder, PizzaOrderContext> item in _pizzas)
			{
				item.Key.Deliver(item.Value.Address);
			}
			Console.WriteLine($"The {_pizzaFactory.Count} pizza objects were created.");
		}
	}
}
