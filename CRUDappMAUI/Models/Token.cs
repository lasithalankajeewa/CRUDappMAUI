using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDappMAUI.Models
{
    public class Token
    {
        public int CompanyId { get; set; }

        public int UserKey { get; set; }

        public int ObjKy { get; set; }

        public int EmpKy { get; set; }

        public LeaveTypesParam LeaveType { get; set; }

        public int LeaveTrnKy { get; set; }

        public int LeaveTrnTypKy { get; set; }

        public string EftvDt { get; set; }

        public string ToD { get; set; }

        public string LevDays { get; set; } 

        public LevReasonParam LevReason { get; set; } 
        
        public bool IsFirstHalf { get; set; }

        public bool IsSecondHalf { get; set; }

        public bool IsAct { get; set; }

        public int AcsLvlKy { get; set; }
        
        public int ConFinLvlKy { get; set; }

        public int ReporterKy { get; set; }

        public string Rem { get; set; }

        public string ReqDate { get; set; }

       

    }

    public class LeaveTypesParam
    {
        public int CodeKey { get; set; }
    }

    public class LevReasonParam
    {
        public int CodeKey { get; set; }
    }
}
