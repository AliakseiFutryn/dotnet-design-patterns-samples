using FactoryMethod.Abstract;
using FactoryMethod.Entities;
using FactoryMethod.Entities.Enums;

namespace FactoryMethod.Impl
{
	public static class LaborExchange
	{
		/// <summary>
		/// Gets an employee from the labor exchange.
		/// </summary>
		/// <param name="profession">Profession type.</param>
		/// <returns>The employee.</returns>
		public static Employee GetEmployee(Profession profession)
		{
			switch(profession)
			{
				case Profession.Dentist: return new Dentist();
				case Profession.Teacher: return new Teacher();
				case Profession.Programer: return new Programer();
			}
			return null;
		}
	}
}
