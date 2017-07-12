using System;

namespace Mediator.Impl
{
	internal class EventsMediator
	{
		private bool _disposed;

		private MicrosoftMessageSender _microsoftMessageSender;
		private readonly AppleMessageReceiver _appleMessageReceiver;

		public EventsMediator(AppleMessageReceiver appleMessageReceiver,
							  MicrosoftMessageSender microsoftMessageSender)
		{
			_appleMessageReceiver = appleMessageReceiver;
			_microsoftMessageSender = microsoftMessageSender;
			_microsoftMessageSender.MessageEvent += OnMessageReceived;
		}

		#region Private methods

		private void OnMessageReceived(string message)
		{
			_appleMessageReceiver.Message = message;
		}

		#endregion

		#region Dispose pattern

		~EventsMediator()
		{
			Dispose(false);
		}

		/// <summary>
		/// Releases unmanaged and - optionally - managed resources.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		
		protected void Dispose(bool disposing)
		{
			if (!_disposed && disposing)
			{
				_microsoftMessageSender.MessageEvent -= OnMessageReceived;
				_microsoftMessageSender = null;
			}
			_disposed = true;
		}
		
		#endregion
	}
}
