using AbstractFactory.Abstract;
using AbstractFactory.Entities.Enums;

namespace AbstractFactory.Impl
{
	public static class WorkplaceEquipmentFactories
	{
		/// <summary>
		/// Gets the workplace equipment factory.
		/// </summary>
		/// <param name="company">Company.</param>
		/// <returns>Workplace equipment factory.</returns>
		public static IWorkplaceEquipmentFactory GetFactory(Company company)
		{
			switch(company)
			{
				case Company.Apple: return new AppleWorkplaceEquipmentFactory();
				case Company.Hp: return new HpWorkplaceEquipmentFactory();
				case Company.Microsoft: return new MicrosoftWorkplaceEquipmentFactory();
			}
			return null;
		}
	}
}
