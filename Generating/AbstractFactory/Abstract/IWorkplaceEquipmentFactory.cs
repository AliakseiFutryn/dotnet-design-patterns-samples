namespace AbstractFactory.Abstract
{
	public interface IWorkplaceEquipmentFactory
	{
		/// <summary>
		/// Gets a mouse.
		/// </summary>
		/// <returns>The mouse.</returns>
		IMouse GetMouse();

		/// <summary>
		/// Gets a tablet.
		/// </summary>
		/// <returns>The tablet.</returns>
		ITablet GetTablet();

		/// <summary>
		/// Gets a  laptop.
		/// </summary>
		/// <returns>The laptop.</returns>
		ILaptop GetLaptop();
	}
}
