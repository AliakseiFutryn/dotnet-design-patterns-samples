namespace AbstractFactory.Abstract
{
	public interface ITablet : IWorkplaceEquipment
	{
		/// <summary>
		/// The number of cores.
		/// </summary>
		int CoresCount { get; }
	}
}
