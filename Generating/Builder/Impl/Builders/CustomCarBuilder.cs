using Builder.Entities;
using Enums = Builder.Entities.Enums;

namespace Builder.Impl.Builders
{
	public class CustomCarBuilder
	{
		private Car _car;

		public CustomCarBuilder()
		{
			_car = new Car();
		}

		/// <summary>
		/// Sets the car mark.
		/// </summary>
		/// <returns>Car builder.</returns>
		public CustomCarBuilder Mark(string mark)
		{
			_car.Mark = mark;
			return this;
		}

		/// <summary>
		/// Sets the car model.
		/// </summary>
		/// <returns>Car builder.</returns>
		public CustomCarBuilder Model(string model)
		{
			_car.Model = model;
			return this;
		}

		/// <summary>
		/// Sets the car color.
		/// </summary>
		/// <returns>Car builder.</returns>
		public CustomCarBuilder Color(string color)
		{
			_car.Color = color;
			return this;
		}

		/// <summary>
		/// Sets the number of car horses.
		/// </summary>
		/// <returns>Car builder.</returns>
		public CustomCarBuilder Horses(int horses)
		{
			_car.Horses = horses;
			return this;
		}

		/// <summary>
		/// Sets the car transmission.
		/// </summary>
		/// <returns>Car builder.</returns>
		public CustomCarBuilder Transmission(Enums.Transmission transmission)
		{
			_car.Transmission = transmission;
			return this;
		}

		/// <summary>
		/// Returns built entity.
		/// </summary>
		/// <returns>The car.</returns>
		public Car Build()
		{
			return _car;
		}
	}
}
