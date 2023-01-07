using CommunityToolkit.Maui.Views;
using CRUDappMAUI.Models;
using CRUDappMAUI.ViewModel;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CRUDappMAUI.Pages;

public partial class AddLeavePage : ContentPage

{
	public DateTime SelectedDate { get; set; }
    //public string Title { get; set; }
    AddLeaveViewModel leavemodel;
    public AddLeavePage()
	{
		InitializeComponent();
        //this.BindingContext = new LeaveTypeViewModel();
        //this.BindingContext = this;
         leavemodel=new AddLeaveViewModel();
        this.BindingContext= leavemodel;

        if (leavemodel.IsPopUp) {
            var popup = new SortPopup();
            this.ShowPopup(popup);
        }





    }

     void OnSubmitClicked(object sender, EventArgs e)
    {
        Debug.WriteLine("--Submit button Clicked");


        
    }

    private void Switch1_Toggled(object sender, ToggledEventArgs e)
    {
        leavemodel.OnToggleSwitch(e.Value);
    }

    private void Switch2_Toggled(object sender, ToggledEventArgs e)
    {
        leavemodel.OnToggleSwitch2(e.Value);
    }

    private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        leavemodel.OnPickerChanged();
    }
}