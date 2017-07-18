namespace Flyweight.Impl
{
	internal class PizzaOrderContext
	{
		public PizzaOrderContext(string address)
		{
			Address = address;
		}

		/// <summary>
		/// Gets the address.
		/// </summary>
		/// <value>The address.</value>
		public string Address { get; private set; }
	}
}
