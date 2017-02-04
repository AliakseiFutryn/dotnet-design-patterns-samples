using NullObject.Entities;

namespace NullObject.Abstract
{
	public abstract class Drink : IDrink
	{
		public static readonly IDrink Null;

		/// <summary>
		/// Initializes the Null value.
		/// </summary>
		static Drink()
		{
			Null = new NullDrink();
		}

		/// <summary>
		/// The drink's cost in the US dollars.
		/// </summary>
		public abstract string Name { get; }

		/// <summary>
		/// The drink name.
		/// </summary>
		public abstract decimal Cost { get; }

		public override string ToString()
		{
			return string.Format("Name: {0}\nCost: {1}\n", Name, Cost);
		}
	}
}
