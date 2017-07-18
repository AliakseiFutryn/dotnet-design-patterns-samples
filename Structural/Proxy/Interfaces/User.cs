namespace Proxy.Interfaces
{
	internal class User
	{
		public User(int age,
					string name)
		{
			Age = age;
			Name = name;
		}

		/// <summary>
		/// Gets the age.
		/// </summary>
		/// <value>The age.</value>
		public int Age { get; set; }

		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; }
	}
}
