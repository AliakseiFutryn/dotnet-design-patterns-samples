using Mediator.Entities;

namespace Mediator.Impl
{
	internal class MicrosoftMessageSender
	{
		private event MessageEvent _messageEvent;

		/// <summary>
		/// Occurs when [message event].
		/// </summary>
		public event MessageEvent MessageEvent
		{
			add => _messageEvent += value;
			remove
			{
				if (_messageEvent != null) _messageEvent -= value;
			}
		}

		/// <summary>
		/// Raises the event.
		/// </summary>
		/// <param name="message">The message.</param>
		public void RaiseEvent(string message)
		{
			_messageEvent?.Invoke(message);
		}
	}
}
