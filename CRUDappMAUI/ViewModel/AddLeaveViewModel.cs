using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDappMAUI.ViewModel
{
     public partial class AddLeaveViewModel:ObservableObject
    {
        public AddLeaveViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> _Items;


        [ObservableProperty]
        string text;

        [RelayCommand]
        void Add()
        {
            Text=string.Empty;
        }

    }
}
