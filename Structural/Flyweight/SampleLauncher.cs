using System;
using Flyweight.Impl;

namespace Flyweight
{
	internal class SampleLauncher
	{
		static void Main(string[] args)
		{
			Restaurant restaurant = new Restaurant();

			restaurant.TakeOrder("Mexican", "600 3rd Ave, New York, NY 10016, USA");
			restaurant.TakeOrder("Carbonara", "75 9th Ave, New York, NY 10011, USA");
			restaurant.TakeOrder("Carbonara", "120 Broadway, New York, NY 10271, USA");
			restaurant.TakeOrder("Carbonara", "228 Park Ave S, New York, NY 10003, USA");
			restaurant.TakeOrder("Four cheeses", "55 E 52nd St, New York, NY 10022, USA");
			restaurant.Deliver();

			Console.ReadKey();
		}
	}
}
