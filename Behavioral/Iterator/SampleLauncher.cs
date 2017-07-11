using System;
using Iterator.Impl;

namespace Iterator
{
	internal class SampleLauncher
	{
		static void Main(string[] args)
		{
			ReversContainer<int> reversContainer = new ReversContainer<int>(3);
			reversContainer.Add(1);
			reversContainer.Add(2);
			reversContainer.Add(3);

			foreach (int value in reversContainer)
			{
				Console.WriteLine(value);
			}
			Console.ReadKey();
		}
	}
}
