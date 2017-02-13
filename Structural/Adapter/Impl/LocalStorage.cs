using System.Drawing;
using Adapter.Entities.Enums;

namespace Adapter.Impl
{
	public static class LocalStorage
	{
		/// <summary>
		/// Gets the company logo.
		/// </summary>
		/// <param name="company">The company.</param>
		/// <returns></returns>
		public static Bitmap GetCompanyLogo(Company company)
		{
			switch (company)
			{
				case Company.Google:
					return AdapterResources.GoogleLogo;
				case Company.Microsoft:
					return AdapterResources.MicrosoftLogo;
				default:
					return null;
			}			
		}
	}
}
