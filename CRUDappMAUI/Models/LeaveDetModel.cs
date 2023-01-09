using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDappMAUI.Models
{
    public class LeaveDetModel
    {
        public string LevReason { get; set; }
        public string OtherReason { get; set; }
        public int LevReasonKy { get; set; }
        public string RejectReason { get; set; }
        public int StatusKy { get; set; }
        public string Status { get; set; }
        public string NextStatus { get; set; }
        public string StatusCode { get; set; }
        public string LeaveType { get; set; }
        public int LevTrnKy { get; set; }
        public int LevTrnTypKy { get; set; }
        public int LeaveTypeKy { get; set; }
        public double LevDays { get; set; }
        public string EntitlesD { get; set; }
        public string FromD { get; set; }
        public string ToD { get; set; }
        public string EmpNm { get; set; }
        public long EmpKy { get; set; }
        public bool IsFirstHalf { get; set; }
        public bool IsSecondHalf { get; set; }
        public int ReporterKey { get; set; }
        public string EftvDt { get; set; }
        public int IsCd { get; set; }
        public DateTime Year { get; set; }
        public double Taken { get; set; }
        public bool IsPaid { get; set; }
        public string ReqDt { get; set; }
        public CodeBaseResponse NextApprovedStatus { get; set; }

    }
}
