using CRUDappMAUI.Pages;
using System.Diagnostics;

namespace CRUDappMAUI;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
    }

    async void OnAddLeaveClicked(object sender, EventArgs e)
    {
        Debug.WriteLine("--Add Leave button Clicked");


        await Shell.Current.GoToAsync(nameof(AddLeavePage));
    }

    async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Debug.WriteLine("--Item Changed clicked");


    }

}

