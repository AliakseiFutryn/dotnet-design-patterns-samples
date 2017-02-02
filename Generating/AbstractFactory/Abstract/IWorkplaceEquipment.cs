using AbstractFactory.Entities.Enums;

namespace AbstractFactory.Abstract
{
	public interface IWorkplaceEquipment
	{
		/// <summary>
		/// The model of office equipment.
		/// </summary>
		string Model { get; }

		/// <summary>
		/// The vendor of office equipment.
		/// </summary>
		Company Vendor { get; }

		/// <summary>
		/// The price of office equipment.
		/// </summary>
		decimal Price { get; }
	}
}
