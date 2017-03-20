using System;
using System.Collections.Generic;
using Composite.Entities;
using Composite.Entities.Interfaces;
using MicrosoftCompany = Composite.Entities.Microsoft;

namespace Composite
{
	class SampleLauncher
	{
		static void Main(string[] args)
		{
			List<ICompany> companies = new List<ICompany>
			{
				new Apple(),
				new Alphabet(),
				new MicrosoftCompany()
			};

			Console.WriteLine("Companies revenue:");
			companies.ForEach(company => Console.WriteLine(company.ToString()));
			Console.ReadKey();
		}
	}
}
