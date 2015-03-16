using System;
using Gtk;

/// <summary>
/// The MementoEditor is a simple text editor with a save and restore function.
/// The MementoEditor uses the Memento design pattern to store the text.
/// 
/// Authors Mark Roelans and Valentijn Harmers
/// </summary>


namespace MementoEditor
{
	class MainClass
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// 
		/// This method creates a new GTK+ form. Intall the GTK+ .NET extention if you wan't 
		/// to run this program in a non Mono environment.
		/// 
		/// You can download the GTK+ .NET extention (GTK# for .NET) from 
		/// the following url: http://www.mono-project.com/download/#download-win
		/// 
		/// More information about GTK# for .NET: http://www.mono-project.com/docs/gui/gtksharp/installer-for-net-framework/
		/// </summary>
		/// <param name='args'>
		/// The command-line arguments.
		/// </param>
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}
