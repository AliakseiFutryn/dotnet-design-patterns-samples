using System;
using Dispose.Impl;

namespace Dispose
{
	internal class SampleLauncher
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"Total memory without windows manager resource: {GC.GetTotalMemory(false)}");
			WindowsManager windowsManager = new WindowsManager(IntPtr.Zero);
			Console.WriteLine($"Total memory with windows manager resource: {GC.GetTotalMemory(false)}");
			windowsManager.Dispose();
			Console.WriteLine($"Total memory after disposing windows manager resource: {GC.GetTotalMemory(true)}");

			Console.ReadKey();
		}
	}
}
