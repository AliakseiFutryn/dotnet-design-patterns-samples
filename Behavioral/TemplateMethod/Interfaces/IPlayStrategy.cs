namespace TemplateMethod.Interfaces
{
	internal interface IPlayStrategy
	{
		/// <summary>
		/// Plays the specified player.
		/// </summary>
		/// <param name="player">The player.</param>
		void Play(IPlayer player);
	}
}
