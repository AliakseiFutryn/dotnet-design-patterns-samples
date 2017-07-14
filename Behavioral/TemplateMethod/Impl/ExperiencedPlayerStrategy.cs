using TemplateMethod.Interfaces;

namespace TemplateMethod.Impl
{
	internal class ExperiencedPlayerStrategy : IPlayStrategy
	{
		public void Play(IPlayer player)
		{
			player.Scores += 2;
		}
	}
}
