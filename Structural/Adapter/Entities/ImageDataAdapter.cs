using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using Adapter.Abstract;

namespace Adapter.Entities
{
	public class ImageDataAdapter : IImageDataAdapter
	{
		private readonly ImageData _imageData;

		public ImageDataAdapter(ImageData imageData)
		{
			_imageData = imageData;
		}

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		public string Name
		{
			get
			{
				byte[] base64EncodedBytes = Convert.FromBase64String(_imageData.EncodedName);
				return Encoding.UTF8.GetString(base64EncodedBytes);
			}
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					byte[] bytes = Encoding.UTF8.GetBytes(value);
					_imageData.EncodedName = Convert.ToBase64String(bytes);
				}
			}
		}

		/// <summary>
		/// Gets or sets the image.
		/// </summary>
		/// <value>
		/// The image.
		/// </value>
		public Bitmap Image
		{
			get
			{
				if (_imageData.ImageArray != null) return new Bitmap(new MemoryStream(_imageData.ImageArray));
				return null;
			}
			set
			{
				if (value != null)
				{
					using (MemoryStream memoryStream = new MemoryStream())
					{
						value.Save(memoryStream, ImageFormat.Png);
						_imageData.ImageArray = memoryStream.ToArray();
					}
				}
			}
		}

		/// <summary>
		/// Gets the string representation.
		/// </summary>
		/// <returns>
		/// The string representation.
		/// </returns>
		public override string ToString()
		{
			return $"Name: {Name}\nImageType: {Image.GetType().Name}";
		}
	}
}
