using CommunityToolkit.Maui.Views;
using CRUDappMAUI.Pages;
using System.Diagnostics;

namespace CRUDappMAUI;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
        this.BindingContext=new LeaveHistoryViewModel();
       
    }

    async void OnAddLeaveClicked(object sender, EventArgs e)
    {
        Debug.WriteLine("--Add Leave button Clicked");


        await Shell.Current.GoToAsync(nameof(AddLeavePage));
    }

     void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Debug.WriteLine("--Item Changed clicked");


    }

    public void IsRefreshing()
    {
        Debug.WriteLine("--IS refresh Clicked");
    }

    async void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;

        if (selectedIndex != -1)
        {
            this.ShowPopup(new SortPopup());
        }
    }

}

