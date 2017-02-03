using FactoryMethod.Abstract;
using FactoryMethod.Entities.Skills;

namespace FactoryMethod.Entities
{
	public class Teacher : Employee
	{
		/// <summary>
		/// Initializes dentists skills
		/// </summary>
		protected override void InitializeSkills()
		{
			AddSkills(new PlanningSkill(),
					  new SelfMotivationSkill(),
					  new TeamworkSkill());
		}
	}
}
