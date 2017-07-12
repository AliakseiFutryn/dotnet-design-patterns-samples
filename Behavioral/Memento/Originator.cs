using System;
using Memento.Entities;

namespace Memento
{
	internal class Originator
	{
		private Context _context;

		/// <summary>
		/// Sets the context.
		/// </summary>
		/// <param name="context">The context.</param>
		public void SetContext(Context context)
		{
			_context = context;
			Console.WriteLine($"The context with user: {context.User} and email: {context.Email} was set.");
		}

		/// <summary>
		/// Saves to momento.
		/// </summary>
		/// <returns></returns>
		public Entities.Memento SaveToMomento()
		{
			Console.WriteLine("Saving to memento...");
			return new Entities.Memento(_context);
		}

		/// <summary>
		/// Restores from memento.
		/// </summary>
		/// <param name="memento">The memento.</param>
		public void RestoreFromMemento(Entities.Memento memento)
		{
			_context = memento.Context;
			Console.WriteLine($"The context with user: {_context.User} and email: {_context.Email} was restored.");
		}
	}
}
