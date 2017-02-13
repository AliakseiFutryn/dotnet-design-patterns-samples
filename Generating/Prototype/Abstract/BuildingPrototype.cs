using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype.Abstract
{
	[Serializable]
	public abstract class BuildingPrototype : ICloneable
	{
		/// <summary>
		/// The height of a building.
		/// </summary>
		public abstract int Height { get; set; }

		/// <summary>
		/// The name of a building.
		/// </summary>
		public abstract string Name { get; set; }

		/// <summary>
		/// Clones the object.
		/// </summary>
		/// <returns>Cloned object.</returns>
		public abstract object Clone();

		/// <summary>
		/// Gets a string representation of an object.
		/// </summary>
		/// <returns>The string representation.</returns>
		public override string ToString()
		{
			return $"Name: {Name}\nHeight: {Height}\n";
		}

		protected object DeepClone()
		{
			object itemClone = MemberwiseClone();
			if (itemClone != null)
			{
				using (MemoryStream stream = new MemoryStream())
				{
					BinaryFormatter formatter = new BinaryFormatter();
					formatter.Serialize(stream, itemClone);
					stream.Position = 0;
					return formatter.Deserialize(stream);
				}

			}
			return null;
		}
	}
}
