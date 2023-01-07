using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDappMAUI.Models
{
    public class LeaveSumModel
    {

        public int EmpKy { get; set; }
        public int LeaveTypeKy { get; set; }
        public int Elagible { get; set; }
        public int Taken { get; set; }
        public DateTime EftvDt { get; set; }
        public DateTime ToDt { get; set; }
        public int Bal { get; set; }
        public string LeaveType { get; set; }
        public int IsCd01 { get; set; }
    }
}
