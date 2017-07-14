using TemplateMethod.Entities;
using TemplateMethod.Interfaces;

namespace TemplateMethod.Impl
{
	internal class PlayStrategyFactory : IPlayStrategyFactory
	{
		public IPlayStrategy GetPlayStrategy(IPlayer player)
		{
			if(player is ExperiencedPlayer) return new ExperiencedPlayerStrategy();
			return new TypicalPlayerStrategy();
		}
	}
}
