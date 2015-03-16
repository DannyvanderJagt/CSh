using System;

namespace MementoEditor
{
	/// <summary>
	/// The Memento saves one instance of a object so it can be restored at a later time
	/// </summary>
	public class Memento<T>
	{
		private T obj;
		private readonly string name;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="MementoEditor.Memento`1"/> class.
		/// </summary>
		/// <param name='name'>
		/// 	The name of the Memento
		/// </param>
		public Memento (string name)
		{
			this.name = name;
		}
		
		/// <summary>
		/// Save the specified objToSave.
		/// </summary>
		/// <param name='objToSave'>
		/// Object to save.
		/// </param>
		public void Save(T objToSave)
		{
			obj = objToSave;
		}
		
		/// <summary>
		/// 	Restore the saved instance.
		/// </summary>
		/// <returns>
		/// 	The restored object
		/// </returns>
		public T Restore()
		{
			return obj;
		}
		
		public override string ToString ()
		{
			return name;
		}
	}
}

