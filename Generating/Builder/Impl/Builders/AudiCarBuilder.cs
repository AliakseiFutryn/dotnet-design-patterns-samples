using Builder.Abstract;
using Enums = Builder.Entities.Enums;

namespace Builder.Impl.Builders
{
	public class AudiCarBuilder : CarBuilder
	{
		/// <summary>
		/// Builds the car mark.
		/// </summary>
		/// <returns>Car builder.</returns>
		public override CarBuilder BuildMark()
		{
			Car.Mark = "Audi";
			return this;
		}

		/// <summary>
		/// Builds the car model.
		/// </summary>
		/// <returns>Car builder.</returns>
		public override CarBuilder BuildModel()
		{
			Car.Model = "A5";
			return this;
		}

		/// <summary>
		/// Builds the car color.
		/// </summary>
		/// <returns>Car builder.</returns>
		public override CarBuilder BuildColor()
		{
			Car.Color = "White";
			return this;
		}

		/// <summary>
		/// Builds the number of car horses.
		/// </summary>
		/// <returns>Car builder.</returns>
		public override CarBuilder BuildHorses()
		{
			Car.Horses = 155;
			return this;
		}

		/// <summary>
		/// Builds the car transmission.
		/// </summary>
		/// <returns>Car builder.</returns>
		public override CarBuilder BuildTransmission()
		{
			Car.Transmission = Enums.Transmission.Manual;
			return this;
		}
	}
}
