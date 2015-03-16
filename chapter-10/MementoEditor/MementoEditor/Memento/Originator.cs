using System;

namespace MementoEditor
{
	/// <summary>
	/// 	The Originator keeps the current text (state).
	///		The Originator can create new Memento's and is able to restore
	/// 	from created Memento's
	/// </summary>
	public class Originator<T>
	{
		public T state {get;set;}
		//Each created memento has a unique name.
		private int mementoCount;
		
		public Originator ()
		{
			mementoCount = 0;
		}
		
		/// <summary>
		/// Creates a memento (snapshot) of the state
		/// </summary>
		/// <returns>
		/// The memento.
		/// </returns>
		public Memento<T> CreateMemento()
		{
			mementoCount++;
			//Create a unique name for the Memento
			string mementoName = "Save " + mementoCount;
			
			Memento<T> memento = new Memento<T>(mementoName);
			memento.Save(state);
			return memento;
		}
		
		/// <summary>
		/// Restore's 
		/// </summary>
		/// <param name='memento'>
		/// Memento.
		/// </param>
		public void SetMemento(Memento<T> memento)
		{
			state = memento.Restore();
		}
	}
}

