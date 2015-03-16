using System;
using Gtk;
using MementoEditor;

/// <summary>
/// 	This class is het MainWindows of the Editor. The editor contains a textview, 
/// 	a save button, a restore button and a quit button.
/// 
/// 	The user can save the state of the textview by pressing the save button. The user
/// 	can restore the state by pressing the restore button.
/// </summary>

public partial class MainWindow: Gtk.Window
{	
	private RestoreDialog restoreDialog;
	private CareTaker<Memento<string>> careTaker;
	private Originator<string> originator;
	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		careTaker = new CareTaker<Memento<string>>();
		originator = new Originator<string>();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
	/// <summary>
	/// Raises the quit button clicked event.
	/// </summary>
	/// <param name='sender'>
	/// Sender.
	/// </param>
	/// <param name='e'>
	/// E.
	/// </param>
	protected void OnQuitButtonClicked (object sender, System.EventArgs e)
	{
		Application.Quit();
	}
	
	/// <summary>
	/// Raises the restore button clicked event.
	/// </summary>
	/// <param name='sender'>
	/// Sender.
	/// </param>
	/// <param name='e'>
	/// E.
	/// </param>
	protected void OnRestoreButtonClicked (object sender, System.EventArgs e)
	{
		//Create and new restoreDialog (lazy init)
		if(restoreDialog == null)
		{
			restoreDialog = new RestoreDialog();	
			restoreDialog.OnItemChosenEvent += new RestoreDialog.RestoreDelegate(RestoreText);
		}
		restoreDialog.SetOptions(careTaker);
		restoreDialog.Show();
	}
	
	/// <summary>
	/// Restores the text from a given Memento.
	/// This method is a callback method of the RestoreDialog.RestoreDelegate
	/// </summary>
	/// <param name='memento'>
	/// Memento.
	/// </param>
	private void RestoreText(object memento)
	{
		originator.SetMemento(memento as Memento<string>);
		mainTextView.Buffer.Text = originator.state;
	}
	
	/// <summary>
	/// Raises the save button clicked event.
	/// </summary>
	/// <param name='sender'>
	/// Sender.
	/// </param>
	/// <param name='e'>
	/// E.
	/// </param>
	protected void OnSaveButtonClicked (object sender, System.EventArgs e)
	{
		originator.state = mainTextView.Buffer.Text;
		careTaker.AddMemento(originator.CreateMemento());
	}
}
