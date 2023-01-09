//using CommunityToolkit.Maui.Views;
using CRUDappMAUI.Pages;
using CRUDappMAUI.ViewModel;
using System.Diagnostics;

namespace CRUDappMAUI;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
        
        MainpageViewModel model= new MainpageViewModel();
        this.BindingContext= model;
       
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

    
}

