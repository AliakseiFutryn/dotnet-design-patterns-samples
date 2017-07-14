namespace Visitor.Interfaces
{
	internal interface IArgument
	{
		/// <summary>
		/// Accepts the specified visitor.
		/// </summary>
		/// <param name="visitor">The visitor.</param>
		void Accept(IVisitor visitor);

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
		string Value { get; set; }
	}
}
