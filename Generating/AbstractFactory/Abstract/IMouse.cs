using AbstractFactory.Entities.Enums;

namespace AbstractFactory.Abstract
{
	public interface IMouse : IWorkplaceEquipment
	{
		/// <summary>
		/// The mouse type.
		/// </summary>
		MouseType Type { get; }
	}
}
