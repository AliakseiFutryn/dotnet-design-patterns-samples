namespace Memento.Entities
{
	internal class Context
	{
		public Context(string user, string email)
		{
			User = user;
			Email = email;
		}

		/// <summary>
		/// Gets or sets the user.
		/// </summary>
		/// <value>The user.</value>
		public string User { get; set; }

		/// <summary>
		/// Gets or sets the email.
		/// </summary>
		/// <value>The email.</value>
		public string Email { get; set; }
	}
}
