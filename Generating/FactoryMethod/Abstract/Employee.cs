using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryMethod.Abstract
{
	public abstract class Employee
	{
		/// <summary>
		/// The employee skills.
		/// </summary>
		private List<Skill> _employeeSkills;

		protected Employee()
		{
			_employeeSkills = new List<Skill>();
			InitializeSkills();
		}

		/// <summary>
		/// The employee skills.
		/// </summary>
		public IEnumerable<Skill> Skills => _employeeSkills;

		/// <summary>
		/// Initializes employee's skills.
		/// </summary>
		protected abstract void InitializeSkills();

		/// <summary>
		/// Adds skill.
		/// </summary>
		protected void AddSkill(Skill skill)
		{
			if (!_employeeSkills.Contains(skill)) _employeeSkills.Add(skill);
		}

		/// <summary>
		/// Adds skills.
		/// </summary>
		/// <param name="skills">The skills.</param>
		protected void AddSkills(params Skill[] skills)
		{
			if (skills == null) throw new Exception("The skills cannot be null.");
			foreach(Skill skill in skills)
			{
				AddSkill(skill);
			}
		}

		/// <summary>
		/// Displays all skills.
		/// </summary>
		public void DisplaySkills()
		{
			Console.WriteLine("Skills: {0}\n", string.Join(", ", _employeeSkills.Select(skill => skill.GetType().Name)));
		}
	}
}
