using TemplateMethod.Interfaces;

namespace TemplateMethod.Entities
{
	internal class Player : IPlayer
	{
		public Player(string name)
		{
			Name = name;
		}
		
		public int Scores { get; set; }
		
		public string Name { get; set; }
	}
}
