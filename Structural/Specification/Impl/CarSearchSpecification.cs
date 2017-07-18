using System.Collections.Generic;
using Specification.Entities;
using Specification.Interfaces;

namespace Specification.Impl
{
	internal class CarSearchSpecification : ICarSearchSpecification
	{
		public CarSearchSpecification(string mark,
									  int maxSpeed,
									  decimal price)
		{
			Mark = mark;
			MaxSpeed = maxSpeed;
			Price = price;
		}

		/// <summary>
		/// Gets or sets the mark.
		/// </summary>
		/// <value>The mark.</value>
		public string Mark { get; set; }

		/// <summary>
		/// Gets or sets the maximum speed.
		/// </summary>
		/// <value>The maximum speed.</value>
		public int MaxSpeed { get; set; }

		/// <summary>
		/// Gets or sets the price.
		/// </summary>
		/// <value>The price.</value>
		public decimal Price { get; set; }

		/// <summary>
		/// Searches the specified cars.
		/// </summary>
		/// <param name="cars">The cars.</param>
		/// <returns>The search result.</returns>
		public IList<Car> Search(IList<Car> cars)
		{
			return new CarMarkSpecification(Mark)
				.Search(new CarMaxSpeedSpecification(MaxSpeed)
				.Search(new CarPriceSpecification(Price)
				.Search(cars)));
		}
	}
}
