using AbstractFactory.Abstract;
using AbstractFactory.Entities.Hp;

namespace AbstractFactory.Impl
{
	public class HpWorkplaceEquipmentFactory : IWorkplaceEquipmentFactory
	{
		/// <summary>
		/// Gets a tablet.
		/// </summary>
		/// <returns>The tablet.</returns>
		public IMouse GetMouse()
		{
			return new HpMouse();
		}

		/// <summary>
		/// Gets a mouse.
		/// </summary>
		/// <returns>The mouse.</returns>
		public ILaptop GetLaptop()
		{
			return new HpEnvy();
		}

		/// <summary>
		/// Gets a  laptop.
		/// </summary>
		/// <returns>The laptop.</returns>
		public ITablet GetTablet()
		{
			return new HpElitePad();
		}
	}
}
