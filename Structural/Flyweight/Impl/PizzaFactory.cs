using System.Runtime.Caching;
using Flyweight.Interfaces;

namespace Flyweight.Impl
{
	internal class PizzaFactory
	{
		private int _count;
		private readonly ObjectCache _cache = MemoryCache.Default;

		/// <summary>
		/// Gets the pizza.
		/// </summary>
		/// <param name="pizzaName">Name of the pizza.</param>
		/// <returns>The pizza.</returns>
		public IPizzaOrder GetPizza(string pizzaName)
		{
			IPizzaOrder cachedPizza = _cache.Get(pizzaName) as IPizzaOrder;
			if(cachedPizza != null) return cachedPizza;

			_count++;
			IPizzaOrder pizza = new Pizza(pizzaName);
			_cache.Set(pizzaName, pizza, ObjectCache.InfiniteAbsoluteExpiration);
			
			return pizza;
		}

		/// <summary>
		/// Gets the count.
		/// </summary>
		/// <value>The count.</value>
		public int Count => _count;
	}
}
