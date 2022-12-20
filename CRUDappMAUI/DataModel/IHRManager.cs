using CRUDappMAUI.Models;

namespace CRUDappMAUI.DataModel
{

    public interface IHRManager : IManager
    {
        bool IsExceptionthrown();
        //Task<UserDetails> GetUserAsync();
        //Task<IList<MultiAtnAnlysis_Response>> GetExistingRecordForDay(MultiAtnAnlysis attendence);
        //Task<InShift> GetShift(ManualAttendence req);
        //Task<MultiAtnAnlysis_Response> InOut(ManualAttendence attendence);
        //Task UpdateRecord(UpdateAttendence attendence);
        //Task<MultiAtnAnlysis_Response> CreateManualAttendence(AddManualAdt attendence);
        //Task<UserPermission> GetUserPermission(UserPermission obj);

        //self leave request 
        Task<IList<LeaveDetails>> GetAlreadyAppliedLeaves();
        Task<int> GetLeaveTrnTypeDetails(LeaveTrnTypeDetails slh);
        //Task<UserDetails> GetReportingPerson(UserDetails req);
        Task<decimal> GetLeaveTypeByCompany(UserDetails usr);
        Task<int> GetMultiApproval(MultiApprovalDetails multiApproval);
        Task<IList<LeaveSummary>> LoadLeaveSummary(LeaveDetails levDet);
        Task ApplyLeave(Leaverequest req);
        Task<int> SelectLeaveCheck(LeaveCheck req);
        Task DeleteLeave(LeaveDetails req);

        Task<IList<LeaveDetails>> LeaveFilter(Leaverequest req);
        Task ChangeLeaveStatus(LeaveStatusChange req);
        //end

        //Task<EmployeeModel> LoadEmployeeDetails();
        //Task<IList<PaySlipDetails>> GeneratePaySlip(SalaryHistory req);
    }
}
