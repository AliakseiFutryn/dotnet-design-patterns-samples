using AbstractFactory.Abstract;
using AbstractFactory.Entities.Apple;

namespace AbstractFactory.Impl
{
	public class AppleWorkplaceEquipmentFactory : IWorkplaceEquipmentFactory
	{
		/// <summary>
		/// Gets a tablet.
		/// </summary>
		/// <returns>The tablet.</returns>
		public IMouse GetMouse()
		{
			return new AppleMouse();
		}

		/// <summary>
		/// Gets a mouse.
		/// </summary>
		/// <returns>The mouse.</returns>
		public ILaptop GetLaptop()
		{
			return new AppleMackBook();
		}

		/// <summary>
		/// Gets a  laptop.
		/// </summary>
		/// <returns>The laptop.</returns>
		public ITablet GetTablet()
		{
			return new AppleIPad();
		}
	}
}
