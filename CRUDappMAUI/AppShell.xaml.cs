using CRUDappMAUI.Pages;

namespace CRUDappMAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(AddLeavePage), typeof(AddLeavePage));
		Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
    }
}
