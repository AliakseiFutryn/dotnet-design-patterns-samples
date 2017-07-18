namespace Specification.Entities
{
	internal class Car
	{
		public Car(string mark,
				   int maxSpeed,
				   decimal price)
		{
			Mark = mark;
			MaxSpeed = maxSpeed;
			Price = price;
		}

		/// <summary>
		/// Gets the mark.
		/// </summary>
		/// <value>The mark.</value>
		public string Mark { get; private set; }

		/// <summary>
		/// Gets the maximum speed.
		/// </summary>
		/// <value>The maximum speed.</value>
		public int MaxSpeed { get; private set; }

		/// <summary>
		/// Gets the price.
		/// </summary>
		/// <value>The price.</value>
		public decimal Price { get; private set; }
	}
}
