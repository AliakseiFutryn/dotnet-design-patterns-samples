using ChainOfResponsibility.Entities;

namespace ChainOfResponsibility.Abstract
{
	public interface ITokenStorage
	{
		/// <summary>
		/// This method is responsible for getting access token
		/// for specific corporation.
		/// </summary>
		/// <param name="resourceType">The type of resource which was requested by user.</param>
		/// <returns>Access token.</returns>
		string GetAccessToken(ResourceType resourceType);
	}
}
