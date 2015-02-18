using System;

namespace VehicleFactoryDemo
{
	/// <summary>
	/// The TruckFactory class is a static factory witch can produce Truck objects.
	/// 
	/// </summary>
	/// 
	
	public static class TruckFactory
	{
				
		/// <summary>
		/// Creates the scania streamline.
		/// </summary>
		/// <returns>
		/// The scania streamline.
		/// </returns>
		public static Truck CreateScaniaStreamline()
		{
			Truck streamline = new Truck("Scania Streamline", "Gray", 30, 2);
			return streamline;	
		}
		
		/// <summary>
		/// Creates the man TG.
		/// </summary>
		/// <returns>
		/// The man TG.
		/// </returns>
		public static Truck CreateManTGM()
		{
			Truck TGM = new Truck("Man TGM", "Red", 18, 1);
			return TGM;
		}
		
		
	}
}

