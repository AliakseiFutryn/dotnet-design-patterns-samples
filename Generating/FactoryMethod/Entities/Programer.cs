using FactoryMethod.Abstract;
using FactoryMethod.Entities.Skills;


namespace FactoryMethod.Entities
{
	public class Programer : Employee
	{
		/// <summary>
		/// Initializes dentists skills
		/// </summary>
		protected override void InitializeSkills()
		{
			AddSkills(new PlanningSkill(),
					  new SelfMotivationSkill(),
					  new CommunicationSkill(),
					  new TeamworkSkill(),
					  new FlexibilitySkill());
		}
	}
}
