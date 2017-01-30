namespace Singleton.Impl
{
	public sealed class DoubleCheckedSingleton<TValue>
		where TValue : new()
	{
		/// <summary>
		/// This field always should be marked as volatile, because
		/// might be a situation when another thread can receive access
		/// to an object which is not fully created.
		/// </summary>
		private static volatile object _instance;
		private static readonly object _syncRoot = new object();

		/// <summary>
		/// This constructor does not allow users to
		/// create a new instance of a singleton.
		/// </summary>
		DoubleCheckedSingleton() { }

		/// <summary>
		/// Gets an instance of TValue class which has only
		/// one representation within a system.
		/// </summary>
		public static TValue Instance
		{
			get
			{
				if(_instance == null)
				{
					lock(_syncRoot)
					{
						if(_instance == null)
						{
							_instance = new TValue();
						}
					}
				}
				return (TValue)_instance;
			}
		}
	}
}
