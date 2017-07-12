using System;
using System.Timers;

namespace Dispose.Impl
{
	internal class WindowsManager : IDisposable
	{
		private Timer _timer;
		private IntPtr _handle;

		public WindowsManager(IntPtr handle)
		{
			_timer = new Timer(1000);
			_timer.Elapsed += OnTimeEvent;
			_handle = handle;
		}

		#region Private methods
		
		private void OnTimeEvent(object sender, ElapsedEventArgs elapsedEventArgs)
		{
			// Something happens.
		}

		#endregion

		#region Dispose pattern

		private bool _disposed;
		
		~WindowsManager()
		{
			Dispose(false);
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Releases unmanaged and - optionally - managed resources.
		/// </summary>
		/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
		protected virtual void Dispose(bool disposing)
		{
			if (!_disposed)
			{
				// Release managed resources if it needs.
				if (disposing)
				{
					_timer.Elapsed -= OnTimeEvent;
					_timer.Dispose();
					_timer = null;
				}
				
				// Release unmanaged resources.
				if (_handle != IntPtr.Zero)
				{
					if (!NativeMethods.CloseWindowStation(_handle))
					{
						// Handle exception.
					}
					_handle = IntPtr.Zero;
				}
				_disposed = true;
			}
		}

		#endregion
	}
}
