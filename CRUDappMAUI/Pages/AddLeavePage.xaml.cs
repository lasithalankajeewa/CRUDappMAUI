using CommunityToolkit.Maui.Views;
using CRUDappMAUI.Models;
using CRUDappMAUI.ViewModel;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CRUDappMAUI.Pages;

public partial class AddLeavePage : ContentPage

{
	public DateTime SelectedDate { get; set; }
    
    AddLeaveViewModel leavemodel;
    public AddLeavePage()
	{
		InitializeComponent();
        
         leavemodel=new AddLeaveViewModel();
        this.BindingContext= leavemodel;

        if (leavemodel.IsPopUp) {
            var popup1 = new SortPopup();
            this.ShowPopup(popup1);

            var pupup2=new SLPopup();
            this.ShowPopup(pupup2);
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

    private void date2Chamged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        leavemodel.OnDate2Chaged();
    }

    private void time2changed(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        leavemodel.OnTime2Chaged();
    }
}