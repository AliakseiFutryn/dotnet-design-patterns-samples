using System;
using Mediator.Impl;

namespace Mediator
{
	internal class SampleLauncher
	{
		static void Main(string[] args)
		{
			MicrosoftMessageSender messageSender = new MicrosoftMessageSender();
			AppleMessageReceiver messageReceiver = new AppleMessageReceiver();
			EventsMediator eventsMediator = new EventsMediator(messageReceiver, messageSender);

			messageSender.RaiseEvent("Hello world!");
			eventsMediator.Dispose();
			
			Console.WriteLine(messageReceiver.Message);
			Console.ReadKey();
		}
	}
}
