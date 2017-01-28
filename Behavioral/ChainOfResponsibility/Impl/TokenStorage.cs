using ChainOfResponsibility.Abstract;
using ChainOfResponsibility.Entities;

namespace ChainOfResponsibility.Impl
{
	public class TokenStorage : ITokenStorage
	{
		private Handler _accessTokenHandler;

		/// <summary>
		/// This constructor is responsible for creating the chain
		/// of access token handlers.
		/// </summary>
		public TokenStorage()
		{
			_accessTokenHandler = new FacebookAccessTokenHandler(new GoogleAccessTokenHandler(new MicrosoftAccessTokenHandler(null)));
		}

		/// <summary>
		/// This method is responsible for getting access token
		/// for specific corporation.
		/// </summary>
		/// <param name="resourceType">The type of resource which was requested by user.</param>
		/// <returns>Access token.</returns>
		public string GetAccessToken(ResourceType resourceType)
		{
			return _accessTokenHandler.GetAccessToken(resourceType);
		}
	}
}
