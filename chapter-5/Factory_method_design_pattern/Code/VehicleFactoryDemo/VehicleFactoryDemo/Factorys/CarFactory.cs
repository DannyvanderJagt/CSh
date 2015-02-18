using System;

namespace VehicleFactoryDemo
{
	/// <summary>
	/// The CarFactory class is a static factory witch can produce Car objects.
	/// 
	/// </summary>
	/// 
	public static class CarFactory
	{
		/// <summary>
		/// Creates the toyota prius.
		/// </summary>
		/// <returns>
		/// The toyota prius.
		/// </returns>
		public static Car CreateToyotaPrius()
		{
			Car prius = new Car("Toyota Prius", "Silver", true);
			return prius;
		}
		
		/// <summary>
		/// Creates the VW polo.
		/// </summary>
		/// <returns>
		/// The VW polo.
		/// </returns>
		public static Car CreateVWPolo()
		{
			Car polo = new Car("Volkswagen Polo", "Black", false);	
			return polo;
		}
		
		/// <summary>
		/// Creates the audi a1.
		/// </summary>
		/// <returns>
		/// The audi a1.
		/// </returns>
		public static Car CreateAudiA1()
		{
			Car audi = new Car("Audi A1", "Blue", false);	
			return audi;
		}
	}
}

