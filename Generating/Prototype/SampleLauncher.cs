using System;
using Prototype.Entities;

namespace Prototype
{
	class SampleLauncher
	{
		static void Main(string[] args)
		{
			LibertyPlaza libertyPlaza = new LibertyPlaza("LibertyPlaza", 300, 100);
			LibertyPlaza clonedLibertyPlaza = libertyPlaza.Clone() as LibertyPlaza;
			if(clonedLibertyPlaza != null)
			{
				Console.WriteLine(libertyPlaza);
				Console.WriteLine(clonedLibertyPlaza);
				Console.WriteLine("The both entities referenced to the same object: {0}\n", ReferenceEquals(libertyPlaza, clonedLibertyPlaza));
			}
			else Console.WriteLine("Object cloning was not succesfully.");

			Console.WriteLine("Please enter any key to continue...");
			Console.ReadKey();
		}
	}
}
