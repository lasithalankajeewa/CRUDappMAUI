using CommunityToolkit.Maui.Views;

namespace CRUDappMAUI.Pages;

public partial class SortPopup : Popup
{
	public SortPopup()
	{
		InitializeComponent();
	}

	async void OnOKButtonClicked(object? sender, EventArgs e) 
	{

		Close();
        await Shell.Current.GoToAsync("MainPage");
    }

}