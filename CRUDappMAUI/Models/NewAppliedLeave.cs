
namespace CRUDappMAUI.Models


{
    public class NewAppliedLeave
    {
        public string LevReason { get; set; }
        public string OtherReason { get; set; }
        public int LevReasonKy { get; set; }
        public string RejectReason { get; set; }
        public int StatusKy { get; set; }
        public string Status { get; set; }
        public object NextStatus { get; set; }
        public string StatusCode { get; set; }
        public string LeaveType { get; set; }
        public int LevTrnKy { get; set; }
        public int LevTrnTypKy { get; set; }
        public int LeaveTypeKy { get; set; }
        public float LevDays { get; set; }
        public object EntitlesD { get; set; }
        public object FromD { get; set; }
        public string ToD { get; set; }
        public string EmpNm { get; set; }
        public int EmpKy { get; set; }
        public bool IsFirstHalf { get; set; }
        public bool IsSecondHalf { get; set; }
        public int ReporterKey { get; set; }
        public string EftvDt { get; set; }
        public int IsCd { get; set; }
        public DateTime Year { get; set; }
        public float Taken { get; set; }
        public bool IsPaid { get; set; }
        public object NextApprovedStatus { get; set; }
        public object ReqDt { get; set; }
    }
}



