using CRUDappMAUI.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CRUDappMAUI.Pages;

public partial class AddLeavePage : ContentPage

{
	public DateTime SelectedDate { get; set; }
    //public string Title { get; set; }

    public AddLeavePage()
	{
		InitializeComponent();
        this.BindingContext = new LeaveTypeViewModel();
        //this.BindingContext = this;
		



	}

     void OnSubmitClicked(object sender, EventArgs e)
    {
        Debug.WriteLine("--Submit button Clicked");


        
    }

}