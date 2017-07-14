using System.Linq;
using System.Collections.Generic;
using TemplateMethod.Interfaces;

namespace TemplateMethod.Impl.Games
{
	internal abstract class GameObject
	{
		private IPlayer _winner;
		private readonly IPlayStrategyFactory _playStrategyFactory = new PlayStrategyFactory();

		protected int Scores;
		protected IList<IPlayer> Players;

		protected abstract void InitializeGame();

		protected abstract bool GameEnded();

		/// <summary>
		/// Plays the game.
		/// </summary>
		public void PlayGame()
		{
			InitializeGame();
			while (!GameEnded())
			{
				foreach (IPlayer player in Players)
				{
					MakePlay(player);
				}
			}
			
			IPlayer winner = Players.FirstOrDefault(player => player.Scores >= Scores);
			_winner = winner;
		}

		/// <summary>
		/// Gets the winner.
		/// </summary>
		/// <value>The winner.</value>
		public IPlayer Winner => _winner;
		
		#region Private methods

		private void MakePlay(IPlayer player)
		{
			IPlayStrategy playStrategy = _playStrategyFactory.GetPlayStrategy(player);
			playStrategy.Play(player);
		}
		
		#endregion
	}
}
