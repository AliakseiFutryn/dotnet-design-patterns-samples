using System.Linq;
using System.Collections.Generic;
using TemplateMethod.Entities;
using TemplateMethod.Interfaces;

namespace TemplateMethod.Impl.Games
{
	internal class Chess : GameObject
	{
		protected override void InitializeGame()
		{
			Scores = 10;
			Players = new List<IPlayer>
			{
				new Player("Robert"),
				new ExperiencedPlayer("Martin"),
				new Player("Dinesh")
			};
		}

		protected override bool GameEnded()
		{
			return Players.Any(player => player.Scores >= Scores);
		}
	}
}
