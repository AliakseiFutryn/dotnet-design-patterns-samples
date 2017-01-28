using ChainOfResponsibility.Abstract;
using ChainOfResponsibility.Entities;

namespace ChainOfResponsibility.Impl
{
	internal class GoogleAccessTokenHandler : Handler
	{
		/// <summary>
		/// This constructor is responsible for taking successor
		/// and send it to base class.
		/// </summary>
		/// <param name="successor">The successor.</param>
		public GoogleAccessTokenHandler(Handler successor) : base(successor) { }

		/// <summary>
		/// This method is responsible for getting access token
		/// for specific corporation.
		/// </summary>
		/// <param name="resourceType">The type of resource which was requested by user.</param>
		/// <returns>Access token.</returns>
		internal override string GetAccessToken(ResourceType resourceType)
		{
			if (resourceType == ResourceType.Google) return ChainOfResponsibilityResources.GoogleAccessToken;
			else return GetAccessTokenFromNextLink(resourceType);
		}
	}
}