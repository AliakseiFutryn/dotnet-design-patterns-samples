using System;
using Adapter.Impl;
using Adapter.Abstract;
using Adapter.Entities;
using Adapter.Entities.Enums;

namespace Adapter
{
	class SampleLauncher
	{
		static void Main(string[] args)
		{
			DisplaySample(Company.Google);
			DisplaySample(Company.Microsoft);

			Console.WriteLine("Please enter any key to continue...");
			Console.ReadKey();
		}

		static void DisplaySample(Company company)
		{
			ImageData imageData = new ImageData();
			Console.WriteLine("Company: {0}\n\nClass: {1}\n{2}", company, typeof(ImageData).Name, imageData);

			IImageDataAdapter imageDataAdapter = new ImageDataAdapter(imageData);
			imageDataAdapter.Name = company.ToString();
			imageDataAdapter.Image = LocalStorage.GetCompanyLogo(company);

			Console.WriteLine("\nClass: {0}\n{1}", typeof(ImageData).Name, imageData);
			Console.WriteLine("\nClass: {0}\n{1}\n", imageDataAdapter.GetType().Name, imageDataAdapter);
		}
	}
}
