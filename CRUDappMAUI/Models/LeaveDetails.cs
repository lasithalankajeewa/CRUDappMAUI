using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDappMAUI.Models
{
     public class LeaveDetails
    {
        public string LevReason { get; set; }
        public string OtherReason { get; set; } = "-";
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

    public class Leaverequest
    {
        public int LeaveTrnKy { get; set; }
        public int LeaveTrnTypKy { get; set; }
        public long EmpKy { get; set; } = 1;
        public long ObjKy { get; set; }
        public CodeBaseResponse LeaveType { get; set; } = new CodeBaseResponse();
        public CodeBaseResponse LevReason { get; set; }
        public string OtherReason { get; set; }
        public DateTime? EftvDt { get; set; } = DateTime.Now;
        public DateTime? ToD { get; set; } = DateTime.Now;
        public bool IsFirstHalf { get; set; }
        public bool IsSecondHalf { get; set; }
        public decimal ShortLeaveHours { get; set; }
        public decimal MaxLeaveHour { get; set; }
        public DateTime ReqDate { get; set; } = DateTime.Now;
        public int BalLevDay { get; set; }
        public byte IsPaid { get; set; } = 0;
        public string Rem { get; set; }
        public int IsApr { get; set; }
        public int IsAct { get; set; }
        public int IsLevApr { get; set; }
        public string RefNo { get; set; }
        public int AcsLvlKy { get; set; } = 1;
        public int ConFinLvlKy { get; set; } = 1;
        public float Maint { get; set; }
        public DateTime LeuLevAplDt { get; set; }
        public byte IsAprLeuLev { get; set; }
        public int ReporterKy { get; set; }
        public string Des { get; set; }
        public IList<LeaveSummary> LeaveSummary { get; set; }
        public double LevDays { get; set; } = 1;
        public int NoOfLeaveDays()
        {
            if (ToD != null && EftvDt != null)
                //return ToD.Value.Subtract(EftvDt.Value).Days;
                return new DateTime(ToD.Value.Year, ToD.Value.Month, ToD.Value.Day).Subtract(new DateTime(EftvDt.Value.Year, EftvDt.Value.Month, EftvDt.Value.Day)).Days;
            return 0;

        }
    }

    public class LeaveTrnTypeDetails
    {
        public string ConCd { get; set; }
        public string OurCd { get; set; }
        public long EmpKy { get; set; }
    }

    public class ReportingPersonDetails
    {
        public int AdrKy { get; set; }
        public string AdrNm { get; set; }

    }
    public class LeaveSummary
    {
        public int CompanyId { get; set; }
        public int UserKey { get; set; }
        public string Year { get; set; }   
        public long EmpKy { get; set; }
        public int LeaveTypeKy { get; set; }
        public int Elagible { get; set; }
        public int Taken { get; set; }
        public DateTime EftvDt { get; set; }
        public DateTime ToDt { get; set; }
        public int Bal { get; set; }
        public string LeaveType { get; set; }
        public int IsCd01 { get; set; }

        public double GetLeavDuration()
        {
            return (Convert.ToDateTime(ToDt) - Convert.ToDateTime(EftvDt)).TotalDays;
        }
    }

    public class MultiApprovalDetails
    {
        public int LevTrnTypKy { get; set; }
        public long ObjKy { get; set; }
    }

    public class LeaveCheck
    {
        public int EmpKy { get; set; }
        public DateTime? FromDt { get; set; }
        public DateTime? ToDt { get; set; }
    }

    public class PendingLeave
    {

    }

    public class LeaveStatusChange
    {
        public int TrnKy { get; set; } = 1;
        public int AprResnKy { get; set; } = 1;
        public int AprPrtyKy { get; set; } = 1;
        public bool IsAct { get; set; } = false;
        public long ObjKy { get; set; } = 1;
        public bool IsPaid { get; set; } = false;
        public CodeBaseResponse NextApprovedStatus { get; set; }
    }

}
