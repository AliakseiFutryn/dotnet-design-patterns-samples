using Strategy.Interfaces;

namespace Strategy.Entities
{
	internal class SeniorSoftwareEngineer : IEmployee
	{
		public SeniorSoftwareEngineer()
		{
			Title = "Senior Software Engineer";
		}
		
		public string Title { get; set; }
	}
}
