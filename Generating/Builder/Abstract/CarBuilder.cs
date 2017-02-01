using Builder.Entities;

namespace Builder.Abstract
{
	public abstract class CarBuilder
	{
		protected Car Car;

		/// <summary>
		/// Creates a new Car.
		/// </summary>
		protected CarBuilder()
		{
			Car = new Car();
		}

		#region Building actions

		/// <summary>
		/// Builds a car mark.
		/// </summary>
		/// <returns>The car builder.</returns>
		public abstract CarBuilder BuildMark();

		/// <summary>
		/// Builds a car model.
		/// </summary>
		/// <returns>The car builder.</returns>
		public abstract CarBuilder BuildModel();

		/// <summary>
		/// Builds a car color.
		/// </summary>
		/// <returns>The car builder.</returns>
		public abstract CarBuilder BuildColor();

		/// <summary>
		/// Builds number of car horses.
		/// </summary>
		/// <returns>The car builder.</returns>
		public abstract CarBuilder BuildHorses();

		/// <summary>
		/// Builds a car transmission.
		/// </summary>
		/// <returns>The car builder.</returns>
		public abstract CarBuilder BuildTransmission();

		#endregion

		/// <summary>
		/// Calls all building actions.
		/// </summary>
		/// <returns>The car builder.</returns>
		public CarBuilder Construct()
		{
			BuildMark();
			BuildModel();
			BuildColor();
			BuildHorses();
			BuildTransmission();

			return this;
		}

		/// <summary>
		/// This method should be called after all
		/// building actions.
		/// </summary>
		/// <returns>The car.</returns>
		public Car Build()
		{
			return Car;
		}
	}
}
