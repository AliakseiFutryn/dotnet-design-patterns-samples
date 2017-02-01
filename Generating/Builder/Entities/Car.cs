using Builder.Entities.Enums;

namespace Builder.Entities
{
	public class Car
	{
		/// <summary>
		/// Car mark.
		/// </summary>
		public string Mark { get; set; }

		/// <summary>
		/// Car model.
		/// </summary>
		public string Model { get; set; }

		/// <summary>
		/// Car color.
		/// </summary>
		public string Color { get; set; }

		/// <summary>
		/// Number of horsepower.
		/// </summary>
		public int Horses { get; set; }

		/// <summary>
		/// Transmission type.
		/// </summary>
		public Transmission Transmission { get; set; }

		/// <summary>
		/// Gets summary of the car.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format("Mark: {0}\nModel: {1}\nColor: {2}\nHorses: {3}\nTransmisson: {4}\n", Mark, Model, Color, Horses, Transmission);
		}
	}
}
