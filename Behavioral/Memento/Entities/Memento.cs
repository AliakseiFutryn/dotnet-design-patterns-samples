namespace Memento.Entities
{
	internal class Memento
	{
		private readonly string _user;
		private readonly string _email;

		public Memento(Context context)
		{
			_user = context.User;
			_email = context.Email;
		}

		/// <summary>
		/// Gets the context.
		/// </summary>
		/// <value>The context. </value>
		public Context Context => new Context(_user, _email);
	}
}
