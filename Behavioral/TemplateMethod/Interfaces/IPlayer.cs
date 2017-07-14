namespace TemplateMethod.Interfaces
{
	internal interface IPlayer
	{
		/// <summary>
		/// Gets or sets the scores.
		/// </summary>
		/// <value>The scores.</value>
		int Scores { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		string Name { get; set; }
	}
}
