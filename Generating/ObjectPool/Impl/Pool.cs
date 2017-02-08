using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace ObjectPool.Impl
{
	public static class Pool<TValue>
		where TValue : new()
	{
		private static IList<TValue> _isInUseObjects;
		private static Queue<TValue> _availableObjects;

		static Pool()
		{
			_isInUseObjects = new List<TValue>();
			_availableObjects = new Queue<TValue>();
		}

		/// <summary>
		/// Gets the object of TValue type.
		/// </summary>
		/// <returns>The object.</returns>
		public static TValue GetObject()
		{
			lock (_availableObjects)
			{
				TValue item;
				if (_availableObjects.Count == 0) item = new TValue();
				else item = _availableObjects.Dequeue();

				_isInUseObjects.Add(item);
				return item;
			}
		}

		/// <summary>
		/// Releases object.
		/// </summary>
		/// <param name="item">The item.</param>
		public static void ReleaseObject(TValue item)
		{
			CleanUp(item);
			lock(_availableObjects)
			{
				_isInUseObjects.Remove(item);
				_availableObjects.Enqueue(item);
			}
		}

		/// <summary>
		/// Gets the pool status.
		/// </summary>
		/// <returns>The string with pool status.</returns>
		public static string GetPoolStatus()
		{
			return string.Format("InUse: {0}\nAvailable: {1}\n", _isInUseObjects.Count, _availableObjects.Count);
		}

		#region Private members

		private static void CleanUp(TValue item)
		{
			// Sets default values to all properties.
			item.GetType()
				.GetProperties(BindingFlags.Public)
				.ToList()
				.ForEach(propertyInfo => propertyInfo.SetValue(item, GetDefaultValue(propertyInfo.PropertyType)));

			// Sets default values to all fields.
			item.GetType()
				.GetFields(BindingFlags.Public)
				.ToList()
				.ForEach(fieldInfo => fieldInfo.SetValue(item, GetDefaultValue(fieldInfo.FieldType)));
		}

		private static object GetDefaultValue(Type type)
		{
			if (type.IsValueType) return Activator.CreateInstance(type);
			return null;
		}

		#endregion
	}
}
