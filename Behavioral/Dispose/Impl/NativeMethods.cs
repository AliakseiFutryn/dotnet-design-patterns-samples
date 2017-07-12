using System;
using System.Runtime.InteropServices;

namespace Dispose.Impl
{
	internal static class NativeMethods
	{
		/// <summary>
		/// Closes the window station.
		/// </summary>
		/// <param name="hWinSta">The h win sta.</param>
		/// <returns>The result.</returns>
		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CloseWindowStation(IntPtr hWinSta);
	}
}
