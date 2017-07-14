using Strategy.Interfaces;

namespace Strategy.Entities
{
	internal class SeniorManager : IEmployee
	{
		public SeniorManager()
		{
			Title = "Senior Manager";
		}
		
		public string Title { get; set; }
	}
}
