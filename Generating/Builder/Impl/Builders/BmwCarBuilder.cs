using Builder.Abstract;
using Enums = Builder.Entities.Enums;

namespace Builder.Impl.Builders
{
	public class BmwCarBuilder : CarBuilder
	{
		/// <summary>
		/// Builds the car mark.
		/// </summary>
		/// <returns>Car builder.</returns>
		public override CarBuilder BuildMark()
		{
			Car.Mark = "BMW";
			return this;
		}

		/// <summary>
		/// Builds the car model.
		/// </summary>
		/// <returns>Car builder.</returns>
		public override CarBuilder BuildModel()
		{
			Car.Model = "X5";
			return this;
		}

		/// <summary>
		/// Builds the car color.
		/// </summary>
		/// <returns>Car builder.</returns>
		public override CarBuilder BuildColor()
		{
			Car.Color = "Black";
			return this;
		}

		/// <summary>
		/// Builds the number of car horses.
		/// </summary>
		/// <returns>Car builder.</returns>
		public override CarBuilder BuildHorses()
		{
			Car.Horses = 185;
			return this;
		}

		/// <summary>
		/// Builds the car transmission.
		/// </summary>
		/// <returns>Car builder.</returns>
		public override CarBuilder BuildTransmission()
		{
			Car.Transmission = Enums.Transmission.Automatic;
			return this;
		}
	}
}
