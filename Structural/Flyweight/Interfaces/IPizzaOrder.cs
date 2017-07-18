namespace Flyweight.Interfaces
{
	internal interface IPizzaOrder
	{
		/// <summary>
		/// Delivers the specified address.
		/// </summary>
		/// <param name="address">The address.</param>
		void Deliver(string address);
	}
}
