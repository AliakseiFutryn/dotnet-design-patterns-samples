namespace Singleton.Entities
{
	public class Meeting
	{
		/// <summary>
		/// This constructor is responsible for
		/// initializing meeting data.
		/// </summary>
		public Meeting()
		{
			Subject = SingletonResources.MeetingSubject;
			ParticipantsCount = 100;
		}

		/// <summary>
		/// This property returns the meeting subject.
		/// </summary>
		public string Subject { get; set; }

		/// <summary>
		/// This property returns the total count of 
		/// participants, who will be on the meeting.
		/// </summary>
		public int ParticipantsCount { get; set; }
	}
}
