using FactoryMethod.Abstract;

namespace FactoryMethod.Entities.Skills
{
	public class SelfMotivationSkill : Skill
	{
		/// <summary>
		/// Gets the skill description.
		/// </summary>
		public override string Description => FactoryMethodResources.SelfMotivationSkillDescription;
	}
}
