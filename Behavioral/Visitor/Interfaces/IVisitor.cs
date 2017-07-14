using Visitor.Entities;

namespace Visitor.Interfaces
{
	internal interface IVisitor
	{
		/// <summary>
		/// Visits the specified argument.
		/// </summary>
		/// <param name="argument">The argument.</param>
		void Visit(GeneralArgument argument);

		/// <summary>
		/// Visits the specified argument.
		/// </summary>
		/// <param name="argument">The argument.</param>
		void Visit(SpecialArgument argument);

		/// <summary>
		/// Displays the argument.
		/// </summary>
		/// <param name="argument">The argument.</param>
		void DisplayArgument(IArgument argument);
	}
}
