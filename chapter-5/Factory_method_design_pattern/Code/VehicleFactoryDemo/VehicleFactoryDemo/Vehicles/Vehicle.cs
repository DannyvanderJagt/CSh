using System;

namespace VehicleFactoryDemo
{
	/// <summary>
	/// The vehicle class implements the methods of the IVehicle. Other classed can extend from this
	/// class to get basic functionality and can extend the class whit ther own additional methods.
	/// </summary>
	public class Vehicle : IVehicle
	{
		private readonly string name;
		private readonly string color;
		private bool isDriving;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="VehicleFactoryDemo.Vehicle"/> class.
		/// </summary>
		/// <param name='name'>
		/// Name.
		/// </param>
		/// <param name='color'>
		/// Color.
		/// </param>
		public Vehicle (string name, string color)
		{
			this.name = name;
			this.color = color;
			this.isDriving = false;
		}
		
		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <returns>
		/// The name.
		/// </returns>
		public virtual string GetName()
		{
			return name;
		}
		
		/// <summary>
		/// Gets the color.
		/// </summary>
		/// <returns>
		/// The color.
		/// </returns>
		public string GetColor()
		{
			return color;	
		}
		
		/// <summary>
		/// Starts the driving.
		/// </summary>
		public void StartDriving()
		{
			isDriving = true;
		}
		
		/// <summary>
		/// Stops the driving.
		/// </summary>
		public void StopDriving()
		{
			isDriving = false;
		}
		
		/// <summary>
		/// Determines whether this instance is driving.
		/// </summary>
		/// <returns>
		/// <c>true</c> if this instance is driving; otherwise, <c>false</c>.
		/// </returns>
		public bool IsDriving()
		{
			return isDriving;	
		}
	}
}

