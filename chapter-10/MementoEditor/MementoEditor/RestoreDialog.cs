using System;
using System.Collections;
using Gtk;

namespace MementoEditor
{
	/// <summary>
	/// 	The RestoreDialog lets the user choose a restore point. 
	/// 	The RestoreDialog triggers the OnItemChosenEvent when a user choses a restore point
	/// </summary>
	public partial class RestoreDialog : Gtk.Dialog
	{
		public delegate void RestoreDelegate(object chosenObject);
		public event RestoreDelegate OnItemChosenEvent;
		//The ComboBox GTK# widget uses a ListStore to keep track of the objects
		private ListStore innerList;
		
		public RestoreDialog ()
		{
			this.Build ();
			innerList = new ListStore(typeof(string), typeof(object));
			restoreComboBox.Model = innerList;
		}
		
		/// <summary>
		/// Sets the options of the restoreCombobox.
		/// </summary>
		/// <param name='options'>
		/// Options.
		/// </param>
		public void SetOptions(IEnumerable options)
		{
			innerList.Clear();
			//Add all the IEnumerable values to the restoreCombobox
			foreach(var option in options)
			{
				string optionString = option.ToString();
				innerList.AppendValues(optionString, option);				
			}
		}
				
		protected void OnButtonCancelClicked (object sender, System.EventArgs e)
		{
			this.Hide();
		}
		
		/// <summary>
		/// Raises the button ok clicked event.
		/// </summary>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		protected void OnButtonOkClicked (object sender, System.EventArgs e)
		{
			//No need to send the information when nobody is listening.
			if(OnItemChosenEvent != null)
			{
			
				string chosenOption = restoreComboBox.ActiveText;
				
				//To get the Memento object, we need to iterate over the innerList
				//You need the TreeIter class to iterate over a StoreList. 
				//We initialized the StoreList with two column's. 
				//The first column has the combobox text and the second column has the Memento object.
				
				TreeIter iterator;
				innerList.GetIterFirst(out iterator);
				do
				{
					string currentKey = (string)innerList.GetValue(iterator, 0);
					object currentValue = innerList.GetValue(iterator, 1);
					
					if(currentKey.Equals(chosenOption))
					{
						//Send the chosen memento back to the MainWindow.
						OnItemChosenEvent(currentValue);	
					}	
				}
				while( innerList.IterNext(ref iterator));
			
			}
			
			//Hide the dialog so it can be re-used
			this.Hide();
		}
	}
}

