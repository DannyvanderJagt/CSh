using System;

namespace VehicleFactoryDemo
{
	/// <summary>
	/// The Motorcycle class extends from the Vehicle class and adds a sideCar option to the class.
	/// </summary>
	public class Motorcycle : Vehicle
	{
		private readonly bool sideCar;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="VehicleFactoryDemo.Motorcycle"/> class.
		/// </summary>
		/// <param name='name'>
		/// Name.
		/// </param>
		/// <param name='color'>
		/// Color.
		/// </param>
		/// <param name='hasSideCar'>
		/// Indicates if the motorcycle has a side car attached to it.
		/// </param>
		public Motorcycle (string name,string color, bool hasSideCar): base(name, color)
		{
			this.sideCar = hasSideCar;
		}
		
		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <returns>
		/// The name.
		/// </returns>
		public override string GetName()
		{
			return base.GetName() + " motor";
		}
		
			
		/// <summary>
		/// Determines whether this instance has a side car.
		/// </summary>
		/// <returns>
		/// <c>true</c> if this instance has a side car; otherwise, <c>false</c>.
		/// </returns>
		public bool HasSideCar()
		{
			return sideCar;	
		}
		
		public override string ToString ()
		{
			return "Type: Motorcycle " + 
				"\nName: " + GetName() + 
				"\nColor: " + GetColor() + 
				"\nIsDriving: " + IsDriving().ToString() + 
				"\nHasSideCar: " + HasSideCar().ToString();
		}
	}
}

