using System;

namespace VehicleFactoryDemo
{
	/// <summary>
	/// The Car class extends from the Vehicle class and adds a GPS option to the class.
	/// </summary>
	public class Car : Vehicle
	{
		private readonly bool GPS;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="VehicleFactoryDemo.Car"/> class.
		/// </summary>
		/// <param name='name'>
		/// Name.
		/// </param>
		/// <param name='color'>
		/// Color.
		/// </param>
		/// <param name='hasGPS'>
		/// Indicates if the car has GPS.
		/// </param>
		public Car (string name, string color, bool hasGPS):base(name, color)
		{
			this.GPS = hasGPS;
		}
		
		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <returns>
		/// The name.
		/// </returns>
		public override string GetName()
		{
			return base.GetName() + " car";
		}
		
		/// <summary>
		/// Determines whether this instance has GPS.
		/// </summary>
		/// <returns>
		/// <c>true</c> if this instance has GPS; otherwise, <c>false</c>.
		/// </returns>
		public bool HasGPS()
		{
			return GPS;
		}
		
		public override string ToString ()
		{
			return "Type: Car " + 
				"\nName: " + GetName () + 
				"\nColor: " + GetColor() + 
				"\nIsDriving: " + IsDriving().ToString() + 
				"\nHasGPS: " + HasGPS().ToString();
		}
	}
}

