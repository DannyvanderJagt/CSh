using System;

namespace VehicleFactoryDemo
{
	/// <summary>
	/// The MotorcycleFactory class is a static factory witch can produce Motorcycle objects.
	/// 
	/// </summary>
	/// 
	public static class MotorcycleFactory
	{
		
		/// <summary>
		/// Creates the yamaha YZ.
		/// </summary>
		/// <returns>
		/// The yamaha YZ.
		/// </returns>
		public static Motorcycle CreateYamahaYZF()
		{
			Motorcycle YZF = new Motorcycle("Yamaha ZYF-R1M WE R1", "Gray", false);
			return YZF;
		}
		
		/// <summary>
		/// Creates the BMW f800.
		/// </summary>
		/// <returns>
		/// The BMW f800.
		/// </returns>
		public static Motorcycle CreateBMWF800()
		{
			Motorcycle BMW = new Motorcycle("BMW F 800 R", "Black", false);
			return BMW;
		}
	}
}

