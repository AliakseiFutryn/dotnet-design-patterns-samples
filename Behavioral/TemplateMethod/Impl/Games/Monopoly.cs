using System.Linq;
using System.Collections.Generic;
using TemplateMethod.Entities;
using TemplateMethod.Interfaces;

namespace TemplateMethod.Impl.Games
{
	internal class Monopoly : GameObject
	{
		protected override void InitializeGame()
		{
			Scores = 10;
			Players = new List<IPlayer>
			{
				new Player("Jessica"),
				new Player("John"),
				new ExperiencedPlayer("Karl")
			};
		}

		protected override bool GameEnded()
		{
			return Players.Any(player => player.Scores >= Scores);
		}
	}
}
