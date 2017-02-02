using AbstractFactory.Entities.Enums;

namespace AbstractFactory.Abstract
{
	public interface ILaptop : IWorkplaceEquipment
	{
		/// <summary>
		/// The type of a cpu.
		/// </summary>
		CpuType Cpu { get; }
	}
}
