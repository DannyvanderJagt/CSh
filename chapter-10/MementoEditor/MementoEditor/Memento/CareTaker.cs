using System;
using System.Collections;

namespace MementoEditor
{
	/// <summary>
	/// The CareTaker takes care off the different Memento's
	/// </summary>
	public class CareTaker<T> : IEnumerable
	{
		private readonly ArrayList innerList;
		
		public CareTaker ()
		{
			innerList = new ArrayList();
		}
		
		public IEnumerator GetEnumerator()
		{
			return innerList.GetEnumerator();
		}
		
		/// <summary>
		/// Add a memento to this CareTaker
		/// </summary>
		/// <param name='memento'>
		/// Memento.
		/// </param>
		public void AddMemento(T memento)
		{
			innerList.Add(memento);
		}
	}
}

