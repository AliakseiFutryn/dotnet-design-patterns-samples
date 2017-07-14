using Strategy.Interfaces;

namespace Strategy.Entities
{
	internal class Director : IEmployee
	{
		public Director()
		{
			Title = "Director";
		}
		
		public string Title { get; set; }
	}
}
