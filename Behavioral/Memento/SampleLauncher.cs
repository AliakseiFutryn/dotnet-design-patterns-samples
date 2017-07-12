using System;
using System.Collections.Generic;
using Memento.Entities;

namespace Memento
{
	internal class SampleLauncher
	{
		static void Main(string[] args)
		{
			List<Entities.Memento> savedContexs = new List<Entities.Memento>();
			Originator originator = new Originator();

			originator.SetContext(new Context("Alex", "alex@outlook.com"));
			originator.SetContext(new Context("Mikalai", "mikalai@outlook.com"));
			savedContexs.Add(originator.SaveToMomento());
			originator.SetContext(new Context("Jessica", "jessica@outlook.com"));
			savedContexs.Add(originator.SaveToMomento());
			originator.SetContext(new Context("John", "john@outlook.com"));
			originator.RestoreFromMemento(savedContexs[0]);
			
			Console.ReadKey();
		}
	}
}
