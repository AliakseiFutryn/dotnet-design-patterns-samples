using TemplateMethod.Interfaces;

namespace TemplateMethod.Impl
{
	internal class TypicalPlayerStrategy : IPlayStrategy
	{
		public void Play(IPlayer player)
		{
			player.Scores += 1;
		}
	}
}
