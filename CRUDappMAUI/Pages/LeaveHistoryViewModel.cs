using CRUDappMAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDappMAUI.Pages
{
    public class LeaveHistoryViewModel
    {
        private List<LeaveHistoryModel> _allHistory = new List<LeaveHistoryModel>();
        public List<LeaveHistoryGroup> Employees { get; set; } = new List<LeaveHistoryGroup>();
        public LeaveHistoryViewModel()
        {
            _allHistory.AddRange(new List<LeaveHistoryModel>
            {
                  new LeaveHistoryModel
                {
                    Leave_Type ="test1",
                    FromDate ="test",
                    ToDate ="test",
                    Days_Hours =1,
                    Type ="test",
                    Status= "test",
                    LeaveReason ="test"
                },

                  new LeaveHistoryModel
                {
                    Leave_Type ="test2",
                    FromDate ="test",
                    ToDate ="test",
                    Days_Hours =1,
                    Type ="test",
                    Status= "test",
                    LeaveReason ="test"
                },

                  new LeaveHistoryModel
                {
                    Leave_Type ="test3",
                    FromDate ="test",
                    ToDate ="test",
                    Days_Hours =1,
                    Type ="test",
                    Status= "test",
                    LeaveReason ="test"
                },


            });

            var groupedData = _allHistory.GroupBy(f => f.Leave_Type[0]).Select(f => new LeaveHistoryGroup(f.Key.ToString(), f.ToList()));
            Employees.AddRange(groupedData);
        }

    }
}
