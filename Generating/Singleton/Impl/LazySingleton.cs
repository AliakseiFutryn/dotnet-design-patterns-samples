using System;

namespace Singleton.Impl
{
	public sealed class LazySingleton<TValue>
		 where TValue : new()
	{
		private static readonly Lazy<TValue> _instance;

		/// <summary>
		/// This constructor is responsible for wrapping
		/// TValue class into singleton instance.
		/// </summary>
		static LazySingleton()
		{
			_instance = new Lazy<TValue>(() => new TValue());
		}

		/// <summary>
		/// This constructor does not allow users to
		/// create a new instance of a singleton.
		/// </summary>
		LazySingleton() { }

		/// <summary>
		/// Gets an instance of TValue class which has only
		/// one representation within a system.
		/// </summary>
		public static TValue Instance
		{
			get { return _instance.Value; }
		}
	}
}
