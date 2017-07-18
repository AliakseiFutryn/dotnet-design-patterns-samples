using System.IO;

namespace Proxy.Interfaces
{
	internal interface IDataService
	{
		/// <summary>
		/// Gets the data.
		/// </summary>
		/// <returns>The data.</returns>
		Stream GetData();
	}
}
