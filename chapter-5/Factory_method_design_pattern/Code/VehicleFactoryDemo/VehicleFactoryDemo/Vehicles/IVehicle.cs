using System;

namespace VehicleFactoryDemo
{
	/// <summary>
	/// 	The IVehicle interface defines the functions which a vehicle must have.
	/// </summary>
	public interface IVehicle
	{
		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <returns>
		/// The name.
		/// </returns>
		string GetName();
		/// <summary>
		/// Gets the color.
		/// </summary>
		/// <returns>
		/// The color.
		/// </returns>
		string GetColor();
		/// <summary>
		/// Starts the driving.
		/// </summary>
		void StartDriving();
		/// <summary>
		/// Stops the driving.
		/// </summary>
		void StopDriving();
		/// <summary>
		/// Determines whether this instance is driving.
		/// </summary>
		/// <returns>
		/// <c>true</c> if this instance is driving; otherwise, <c>false</c>.
		/// </returns>
		bool IsDriving();
	}
}

