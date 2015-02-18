using System;

namespace VehicleFactoryDemo
{
	/// <summary>
	/// The Car class extends from the Vehicle class and adds a lenght and trailer count option to the class.
	/// </summary>
	public class Truck : Vehicle
	{
		private readonly int length;
		private readonly int trailerCount;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="VehicleFactoryDemo.Truck"/> class.
		/// </summary>
		/// <param name='name'>
		/// Name.
		/// </param>
		/// <param name='color'>
		/// Color.
		/// </param>
		/// <param name='lenght'>
		/// Lenght.
		/// </param>
		/// <param name='trailerCount'>
		/// Trailer count.
		/// </param>
		public Truck (string name,string color, int lenght, int trailerCount):base(name, color)
		{
			this.length = lenght;
			this.trailerCount = trailerCount;
		}
		
		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <returns>
		/// The name.
		/// </returns>
		public override string GetName()
		{
			return base.GetName() + " truck";
		}
		
		/// <summary>
		/// Gets the lenght in meters.
		/// </summary>
		/// <returns>
		/// The lenght.
		/// </returns>
		public int GetLength()
		{
			return length;
		}
		
		/// <summary>
		/// Gets the trailer count.
		/// </summary>
		/// <returns>
		/// The trailer count.
		/// </returns>
		public int GetTrailerCount()
		{
			return trailerCount;
		}
		
		public override string ToString ()
		{
			return "Type: Truck" + 
				"\nName: " + GetName () + 
				"\nColor: " + GetColor() + 
				"\nIsDriving: " + IsDriving().ToString() + 
				"\nLength: " + GetLength().ToString() +
				"\nTrailers: " + GetTrailerCount().ToString();
		}
	}
}

