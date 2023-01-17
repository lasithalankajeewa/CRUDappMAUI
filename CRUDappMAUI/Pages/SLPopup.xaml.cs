using CommunityToolkit.Maui.Views;

namespace CRUDappMAUI.Pages;

public partial class SLPopup : Popup
{
	public SLPopup()
	{
		InitializeComponent();
	}

    void OnOKButtonClicked(object? sender, EventArgs e)
    {

        Close();
        
    }
}