using System.Linq;
using System.Collections.Generic;
using Specification.Entities;
using Specification.Interfaces;

namespace Specification.Impl
{
	internal class CarMaxSpeedSpecification : ICarSearchSpecification
	{
		private readonly int _maxSpeed;

		public CarMaxSpeedSpecification(int maxSpeed)
		{
			_maxSpeed = maxSpeed;
		}
		
		public IList<Car> Search(IList<Car> cars)
		{
			return cars.Where(car => car.MaxSpeed >= _maxSpeed)
					   .ToList();
		}
	}
}
