using System.Drawing;

namespace Adapter.Abstract
{
	public interface IImageDataAdapter
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		string Name { get; set; }

		/// <summary>
		/// Gets or sets the image.
		/// </summary>
		/// <value>
		/// The image.
		/// </value>
		Bitmap Image { get; set; }
	}
}
