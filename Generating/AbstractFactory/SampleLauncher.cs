using System;
using AbstractFactory.Impl;
using AbstractFactory.Abstract;
using AbstractFactory.Entities.Enums;

namespace AbstractFactory
{
	class SampleLauncher
	{
		static void Main(string[] args)
		{
			ShowWorkplaceEquipment(Company.Hp);
			ShowWorkplaceEquipment(Company.Apple);
			ShowWorkplaceEquipment(Company.Logitech);
			ShowWorkplaceEquipment(Company.Microsoft);

			Console.WriteLine("Please enter any key to exit...");
			Console.ReadKey();
		}

		/// <summary>
		/// Shows all workplace equipment of the company.
		/// </summary>
		/// <param name="company">Company.</param>
		static void ShowWorkplaceEquipment(Company company)
		{
			IWorkplaceEquipmentFactory workplaceEquipmentFactory = WorkplaceEquipmentFactories.GetFactory(company);
			if(workplaceEquipmentFactory == null)
			{
				Console.WriteLine("{0} company did not provide any information about workplace equipments.\n", company);
				return;
			}

			Console.WriteLine("{0} workplace equipments:\n", company);

			IMouse mouse = workplaceEquipmentFactory.GetMouse();
			Console.WriteLine(mouse);

			ILaptop laptop = workplaceEquipmentFactory.GetLaptop();
			Console.WriteLine(laptop);

			ITablet tablet = workplaceEquipmentFactory.GetTablet();
			Console.WriteLine(tablet);
		}
	}
}
