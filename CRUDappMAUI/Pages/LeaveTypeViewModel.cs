using CRUDappMAUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CRUDappMAUI.Pages
{
    public class LeaveTypeViewModel:BaseViewModel
    {
        #region Properties

        private string _buttonText = "Next";
        public string ButtonText
        {
            get => _buttonText;
            set => SetProperty(ref _buttonText, value);
        }

        private int _position;
        public int Position
        {
            get => _position;
            set => SetProperty(ref _position, value, onChanged: (() =>
            {
                if (value == SummeryScreens.Count - 1)
                {
                    ButtonText = "Start";
                }
                else
                {
                    ButtonText = "Next";
                }
            }));
        }

        public ObservableCollection<LeaveType> SummeryScreens { get; set; } = new ObservableCollection<LeaveType>();
        #endregion

        public LeaveTypeViewModel()
        {
            SummeryScreens.Add(new LeaveType
            {

                Type = "Medical",
                Eligible = 11,
                AlreadyTaken = 0,
                Balance = 11,
                Day_Hour = 1
            });

            SummeryScreens.Add(new LeaveType
            {

                Type = "Casual",
                Eligible = 11,
                AlreadyTaken = 0,
                Balance = 11,
                Day_Hour = 1
            });


            SummeryScreens.Add(new LeaveType
            {

                Type = "Medical",
                Eligible = 11,
                AlreadyTaken = 0,
                Balance = 11,
                Day_Hour = 1
            });
        }


        public ICommand NextCommand => new Command( () =>
        {
           
                Position += 1;
           
        });
    }
}
