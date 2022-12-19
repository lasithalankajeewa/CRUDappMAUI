using CRUDappMAUI.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CRUDappMAUI.Pages;

public partial class AddLeavePage : ContentPage

{
	public DateTime SelectedDate { get; set; }

	public AddLeavePage()
	{
		InitializeComponent();
		this.BindingContext = new LeaveTypeViewModel();




	}
	
}