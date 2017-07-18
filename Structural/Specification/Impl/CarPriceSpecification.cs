using System.Linq;
using System.Collections.Generic;
using Specification.Entities;
using Specification.Interfaces;

namespace Specification.Impl
{
	internal class CarPriceSpecification : ICarSearchSpecification
	{
		private readonly decimal _carPrice;

		public CarPriceSpecification(decimal carPrice)
		{
			_carPrice = carPrice;
		}
		
		public IList<Car> Search(IList<Car> cars)
		{
			return cars.Where(car => car.Price <= _carPrice)
					   .ToList();
		}
	}
}
