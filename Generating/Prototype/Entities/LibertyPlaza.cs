using System;
using Prototype.Abstract;

namespace Prototype.Entities
{
	[Serializable]
	public class LibertyPlaza : BuildingPrototype
	{
		public LibertyPlaza(string name, int height, int floors)
		{
			Name = name;
			Height = height;
			Floors = floors;
		}

		/// <summary>
		/// The height of the Liberty Plaza.
		/// </summary>
		public override int Height { get; set; }

		/// <summary>
		/// The name of the Liberty Plaza.
		/// </summary>
		public override string Name { get; set; }

		/// <summary>
		/// The number of floors.
		/// </summary>
		public int Floors { get; set; }

		/// <summary>
		/// Gets a string representation of an object.
		/// </summary>
		/// <returns>The string representation.</returns>
		public override object Clone()
		{
			// This method is available for overriding, you can use
			// your own implementation of Clone methods. It is standart
			// method by default and to use this method you must have to apply
			// [Serializable] attribute.
			return DeepClone();
		}

		/// <summary>
		/// Gets a string representation of an object.
		/// </summary>
		/// <returns>The string representation.</returns>
		public override string ToString()
		{
			return $"{base.ToString()}Floors: {Floors}\n";
		}
	}
}
