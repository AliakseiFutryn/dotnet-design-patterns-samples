using System;
using Builder.Abstract;
using Builder.Impl.Builders;
using Builder.Entities;
using Builder.Entities.Enums;

namespace Builder
{
	class SampleLauncher
	{
		static void Main(string[] args)
		{
			// Builds a car in one action.
			Car audiCar = BuildCar(new AudiCarBuilder());
			Console.WriteLine(audiCar);

			// Builds a car step-by-step.
			Car bmwCar = BuildCarStepByStep(new BmwCarBuilder());
			Console.WriteLine(bmwCar);

			// Builds custom car, it means that you can set
			// each property manually.
			Car customCar = BuildCustomCar(new CustomCarBuilder());
			Console.WriteLine(customCar);

			Console.WriteLine("Please enter any key to exit...");
			Console.ReadKey();
		}

		/// <summary>
		/// This method is responsible for building car in one action.
		/// </summary>
		/// <param name="carBuilder">Car builder.</param>
		/// <returns>The car.</returns>
		static Car BuildCar(CarBuilder carBuilder)
		{
			return carBuilder
				.Construct()
				.Build();
		}

		/// <summary>
		/// This method is responsible for building car step-by-step.
		/// </summary>
		/// <param name="carBuilder">Car builder.</param>
		/// <returns>The car.</returns>
		static Car BuildCarStepByStep(CarBuilder carBuilder)
		{
			return carBuilder
				.BuildMark()
				.BuildModel()
				.BuildColor()
				.BuildHorses()
				.BuildTransmission()
				.Build();
		}

		/// <summary>
		/// This method is responsible for building custom car.
		/// </summary>
		/// <param name="carBuilder">Custom car builder.</param>
		/// <returns>The car.</returns>
		static Car BuildCustomCar(CustomCarBuilder customCarBuilder)
		{
			return customCarBuilder
				.Mark("Volkswagen")
				.Model("Polo")
				.Color("Brown")
				.Horses(120)
				.Transmission(Transmission.Automatic)
				.Build();
		}
	}
}
