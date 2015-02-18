using System;

/// <summary>
/// 	This program demostrates the use of the factory pattern.
/// 	The program uses the VehicleFactory to create IVehicle objects and prints 
/// 	ther information to the screen.
/// 
/// 	An IVehicle object can be an motorcycle, car or truck.
/// 
/// 
/// 	Authors: Mark Roelans and Valentijn Harmers 
/// </summary>
/// 

namespace VehicleFactoryDemo
{
	class MainClass
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name='args'>
		/// The command-line arguments.
		/// </param>
		
		public static void Main (string[] args)
		{
			VehicleFactory factory = new VehicleFactory();
			IVehicle fastVehicle = factory.CreateFastVehicle();
			IVehicle bigVehicle = factory.CreateBigVehicle();
			IVehicle fuelEffVehicle = factory.CreateFuelEfficientVehicle();
			
			Console.WriteLine("My fast vehicle is:");
			Console.WriteLine(fastVehicle.ToString());
			Console.WriteLine();
			
			Console.WriteLine("My big vehicle is:");
			Console.WriteLine(bigVehicle.ToString());
			Console.WriteLine();
			
			Console.WriteLine("My fuel efficient vehicle is:");
			Console.WriteLine(fuelEffVehicle.ToString());
			Console.WriteLine();
			
			Console.ReadKey();
		}
	}
}
