using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDappMAUI.Models
{
    public class LeaveType
    {

        public string Type { get; set; }
        public int Eligible { get; set; }
        public int AlreadyTaken { get; set; }
        public int Balance { get; set; }
        public int Day_Hour { get; set; }
    }
}
