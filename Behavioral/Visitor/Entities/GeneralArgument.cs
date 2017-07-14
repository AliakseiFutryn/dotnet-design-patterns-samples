using Visitor.Interfaces;

namespace Visitor.Entities
{
	internal class GeneralArgument : IArgument
	{
		public GeneralArgument(string value)
		{
			Value = value;
		}
		
		public void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}

		public string Value { get; set; }
	}
}
