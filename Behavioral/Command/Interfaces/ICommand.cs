namespace Command.Interfaces
{
	internal interface ICommand
	{
		/// <summary>
		/// Executes command.
		/// </summary>
		void Execute();

		/// <summary>
		/// Unexecutes command. 
		/// </summary>
		void UnExecute();
	}
}
