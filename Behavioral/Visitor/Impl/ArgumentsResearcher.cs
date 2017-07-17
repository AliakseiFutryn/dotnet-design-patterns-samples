using System;
using Visitor.Entities;
using Visitor.Interfaces;

namespace Visitor.Impl
{
	internal class ArgumentsResearcher : IVisitor
	{
		public void Visit(GeneralArgument argument)
		{
			Console.WriteLine($"General arguments contain {argument.Value.Split().Length} pieces.");
		}

		public void Visit(SpecialArgument argument)
		{
			Console.WriteLine($"Special arguments contain {argument.Value.Split().Length} pieces.");
		}

		public void DisplayArgument(IArgument argument)
		{
			argument.Accept(this);
		}
	}
}
