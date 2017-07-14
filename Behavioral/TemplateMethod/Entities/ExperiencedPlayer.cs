using TemplateMethod.Interfaces;

namespace TemplateMethod.Entities
{
	internal class ExperiencedPlayer : IPlayer
	{
		public ExperiencedPlayer(string name)
		{
			Name = name;
		}
		
		public int Scores { get; set; }
		
		public string Name { get; set; }
	}
}
