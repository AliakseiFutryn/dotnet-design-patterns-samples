using System;
using Visitor.Impl;
using Visitor.Entities;

namespace Visitor
{
	internal class SampleLauncher
	{
		static void Main(string[] args)
		{
			GeneralArgument generalArgument = new GeneralArgument("General argument");
			SpecialArgument specialArgument = new SpecialArgument("Special argument");
			ArgumentsLooker argumentsLooker = new ArgumentsLooker();
			
			argumentsLooker.DisplayArgument(generalArgument);
			argumentsLooker.DisplayArgument(specialArgument);
			Console.ReadKey();
		}
	}
}
