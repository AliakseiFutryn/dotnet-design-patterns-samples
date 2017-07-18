using System;
using System.Collections.Generic;
using Specification.Entities;
using Specification.Impl;
using Specification.Interfaces;

namespace Specification
{
	internal class SampleLauncher
	{
		static void Main(string[] args)
		{
			ICarRepository carRepository = new CarRepository();
			ICarSearchSpecification carSearchSpecification = new CarSearchSpecification("Volkswagen, Polo Sedan", 204, 12750);
			((List<Car>)carRepository.Search(carSearchSpecification)).ForEach(car => Console.WriteLine($"The {car.Mark} was found. The max speed is {car.MaxSpeed}. Price is {car.Price}"));
			Console.ReadKey();
		}
	}
}
