using System;
using TemplateMethod.Impl.Games;

namespace TemplateMethod
{
	internal class SampleLauncher
	{
		static void Main(string[] args)
		{
			GameObject game = new Chess();
			game.PlayGame();
			Console.WriteLine($"The winner in chess game is {game.Winner?.Name}");
			
			game = new Monopoly();
			game.PlayGame();
			Console.WriteLine($"The winner in monopoly game is {game.Winner?.Name}");
			Console.ReadKey();
		}
	}
}
