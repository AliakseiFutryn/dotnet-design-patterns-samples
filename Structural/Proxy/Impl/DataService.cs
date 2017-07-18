using System.IO;
using Proxy.Interfaces;

namespace Proxy.Impl
{
	internal class DataService : IDataService
	{
		public Stream GetData()
		{
			MemoryStream stream = new MemoryStream();
			StreamWriter writer = new StreamWriter(stream);
			writer.Write("This is data from the server.");
			writer.Flush();
			stream.Position = 0;

			return stream;
		}
	}
}
