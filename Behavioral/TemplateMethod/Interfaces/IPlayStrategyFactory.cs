namespace TemplateMethod.Interfaces
{
	internal interface IPlayStrategyFactory
	{
		/// <summary>
		/// Gets the play strategy.
		/// </summary>
		/// <param name="player">The player.</param>
		/// <returns>The play strategy.</returns>
		IPlayStrategy GetPlayStrategy(IPlayer player);
	}
}
