using System.Linq;
using System.Collections.Generic;
using Specification.Entities;
using Specification.Interfaces;

namespace Specification.Impl
{
	internal class CarMarkSpecification : ICarSearchSpecification
	{
		private readonly string _mark;

		public CarMarkSpecification(string mark)
		{
			_mark = mark;
		}
		
		public IList<Car> Search(IList<Car> cars)
		{
			return cars.Where(car => car.Mark.Equals(_mark))
					   .ToList();
		}
	}
}
