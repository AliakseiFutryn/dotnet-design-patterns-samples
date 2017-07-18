using System;
using System.IO;
using Proxy.Impl;
using Proxy.Interfaces;

namespace Proxy
{
	internal class SampleLauncher
	{
		static void Main(string[] args)
		{
			User user = new User(17, "Neil");
			IDataService dataService = new DataServiceProxy(user);
			Stream result = dataService.GetData();
			if (result == Stream.Null)
			{
				user.Age = 18;
				result = dataService.GetData();
				if (result != Stream.Null)
				{
					using (StreamReader streamReader = new StreamReader(result))
					{
						Console.WriteLine(streamReader.ReadToEnd());
					}
				}
			}

			Console.ReadKey();
		}
	}
}
