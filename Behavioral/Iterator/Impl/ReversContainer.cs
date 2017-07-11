using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator.Impl
{
	internal class ReversContainer<T> : IEnumerable<T>
	{
		private int _count;
		private readonly T[] _internalArray;

		public ReversContainer(int arrayLength)
		{
			_internalArray = new T[arrayLength];
		}

		/// <summary>
		/// Gets the <see cref="T"/> at the specified index.
		/// </summary>
		/// <value>The <see cref="T"/>.</value>
		/// <param name="index">The index.</param>
		/// <returns>The current item.</returns>
		/// <exception cref="IndexOutOfRangeException">Index out of range.</exception>
		public T this[int index]
		{
			get
			{
				if (_internalArray.Length > index)
				{
					return _internalArray[index];
				}
				throw new IndexOutOfRangeException("Index out of range.");
			}
		}

		/// <summary>
		/// Gets the count.
		/// </summary>
		/// <value>The count.</value>
		public int Count => _count;

		/// <summary>
		/// Adds the specified item.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <exception cref="ArgumentException">Internal array is full.</exception>
		public void Add(T item)
		{
			if (_internalArray.Length <= _count) throw new ArgumentException("Internal array is full");

			_internalArray[_count] = item;
			_count++;
		}

		/// <summary>
		/// Returns an enumerator that iterates through the collection.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.
		/// </returns>
		public IEnumerator<T> GetEnumerator()
		{
			for (int currentIndex = _count - 1; currentIndex >= 0; currentIndex--)
			{
				yield return _internalArray[currentIndex];
			}
		}

		/// <summary>
		/// Returns an enumerator that iterates through a collection.
		/// </summary>
		/// <returns>
		/// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.
		/// </returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new ReversIterator<T>(this);
		}
	}
}
