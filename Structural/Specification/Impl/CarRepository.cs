using System.Collections.Generic;
using Specification.Entities;
using Specification.Interfaces;

namespace Specification.Impl
{
	internal class CarRepository : ICarRepository
	{
		private readonly IList<Car> _cars = new List<Car>
		{
			new Car("BMW, X5", 245, 40000),
			new Car("BMW, x1", 210, 23000),
			new Car("Mercedes-Benz, E400", 240, 35410),
			new Car("Audi, A5", 250, 19550),
			new Car("Volkswagen, Polo Sedan", 204, 12750),
		};
		
		public IList<Car> Search(ICarSearchSpecification carSearchSpecification)
		{
			return carSearchSpecification.Search(_cars);
		}
	}
}
