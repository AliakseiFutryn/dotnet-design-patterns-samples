using System;
using System.IO;
using Proxy.Interfaces;

namespace Proxy.Impl
{
	internal class DataServiceProxy : IDataService
	{
		private readonly User _user;
		private readonly IDataService _dataService;
		
		public DataServiceProxy(User user)
		{
			_user = user;
			_dataService = new DataService();
		}
		
		public Stream GetData()
		{
			if (_user.Age < 18)
			{
				Console.WriteLine("You can not access the resource, as you are not 18 years old.");
				return Stream.Null;
			}
			return _dataService.GetData();
		}
	}
}
