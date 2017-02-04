namespace NullObject.Abstract
{
	public interface IDrink
	{
		/// <summary>
		/// The drink name.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// The drink's cost in the US dollars.
		/// </summary>
		decimal Cost { get; }
	}
}
