namespace Adapter.Entities
{
	public class ImageData
	{
		public ImageData()
		{
			EncodedName = string.Empty;
			ImageArray = new byte[] {};
		}

		/// <summary>
		/// Gets or sets the encoded name of an image.
		/// </summary>
		/// <value>
		/// The encoded name of an image.
		/// </value>
		public string EncodedName { get; set; }

		/// <summary>
		/// Gets the byte representation of an image.
		/// </summary>
		/// <value>
		/// The byte representation of an image.
		/// </value>
		public byte[] ImageArray { get; set; }

		/// <summary>
		/// Gets the string representation.
		/// </summary>
		/// <returns>
		/// The string representation.
		/// </returns>
		public override string ToString()
		{
			return $"EncodedName: {EncodedName}\nImageType: {ImageArray.GetType().Name}\nBytesCount: {ImageArray.Length}";
		}
	}
}
