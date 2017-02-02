using AbstractFactory.Abstract;
using AbstractFactory.Entities.Microsoft;

namespace AbstractFactory.Impl
{
	public class MicrosoftWorkplaceEquipmentFactory : IWorkplaceEquipmentFactory
	{
		/// <summary>
		/// Gets a tablet.
		/// </summary>
		/// <returns>The tablet.</returns>
		public IMouse GetMouse()
		{
			return new MicrosoftMouse();
		}

		/// <summary>
		/// Gets a mouse.
		/// </summary>
		/// <returns>The mouse.</returns>
		public ILaptop GetLaptop()
		{
			return new MicrosoftSurfaceBook();
		}

		/// <summary>
		/// Gets a  laptop.
		/// </summary>
		/// <returns>The laptop.</returns>
		public ITablet GetTablet()
		{
			return new MicrosoftSurfacePro();
		}
	}
}
