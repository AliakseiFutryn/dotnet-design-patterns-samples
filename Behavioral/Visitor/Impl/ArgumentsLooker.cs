using System;
using Visitor.Entities;
using Visitor.Interfaces;

namespace Visitor.Impl
{
	internal class ArgumentsLooker : IVisitor
	{
		public void Visit(GeneralArgument argument)
		{
			Console.WriteLine($"General arguments: {argument.Value}");
		}

		public void Visit(SpecialArgument argument)
		{
			Console.WriteLine($"Special arguments: {argument.Value}");
		}

		public void DisplayArgument(IArgument argument)
		{
			argument.Accept(this);
		}
	}
}
