using System;

namespace VehicleFactoryDemo
{
	/// <summary>
	/// The VehicleFacory is a non-static class which uses the Car-, Motorcycle- 
	/// and TruckFactory for producing the vehicles
	/// </summary>
	public class VehicleFactory
	{
		private readonly Random generator;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="VehicleFactoryDemo.VehicleFactory"/> class.
		/// </summary>
		public VehicleFactory ()
		{
			generator = new Random();
		}
		
		/// <summary>
		/// Creates the fast vehicle.
		/// </summary>
		/// <returns>
		/// The fast vehicle.
		/// </returns>
		public IVehicle CreateFastVehicle()
		{
			IVehicle fastVehicle = MotorcycleFactory.CreateYamahaYZF();
			return fastVehicle;
		}
		
		/// <summary>
		/// Creates the big vehicle.
		/// </summary>
		/// <returns>
		/// The big vehicle.
		/// </returns>
		public IVehicle CreateBigVehicle()
		{
			IVehicle bigVihicle = TruckFactory.CreateScaniaStreamline();
			return bigVihicle;
		}
		
		/// <summary>
		/// Creates the fuel efficient vehicle. The Vehicle choise is random
		/// so this method will not always generate the same vehicle.
		/// </summary>
		/// <returns>
		/// The fuel efficiant vehicle.
		/// </returns>
		public IVehicle CreateFuelEfficientVehicle()
		{
			IVehicle fuelEffVehicle;
			int randowResult = generator.Next(2);
			
			if(randowResult == 0)
			{
				fuelEffVehicle = CarFactory.CreateToyotaPrius();
			}
			else
			{
				fuelEffVehicle = CarFactory.CreateVWPolo();
			}
						 
			return fuelEffVehicle;
		}
	}
}

