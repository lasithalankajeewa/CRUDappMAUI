using CRUDappMAUI.Models;
using CRUDappMAUI.Routes;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json;

namespace CRUDappMAUI.DataModel
{
    public class HRManager : IHRManager
    {
        private readonly HttpClient _httpClient;
        private bool _checkIfExceptionReturn;
        public HRManager(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }

        //public async Task<UserDetails> GetUserAsync()
        //{
        //    _checkIfExceptionReturn = false;
        //    UserDetails emp = new UserDetails();
        //    LoggedUsers usr = new LoggedUsers();
        //    try
        //    {
        //        var response = await _httpClient.PostAsJsonAsync(TokenEndpoints.Get_User_Details_EndPoint, usr);
        //        await response.Content.LoadIntoBufferAsync();
        //        string content = response.Content.ReadAsStringAsync().Result;
        //        emp = JsonConvert.DeserializeObject<UserDetails>(content);

        //    }
        //    catch (Exception exp)
        //    {
        //        _checkIfExceptionReturn = true;
        //        emp = new UserDetails();
        //    }

        //    return emp;
        //}

        //public async Task<IList<MultiAtnAnlysis_Response>> GetExistingRecordForDay(MultiAtnAnlysis attendence)
        //{
        //    _checkIfExceptionReturn = false;
        //    IList<MultiAtnAnlysis_Response> existingList = new List<MultiAtnAnlysis_Response>();

        //    try
        //    {
        //        var response = await _httpClient.PostAsJsonAsync(TokenEndpoints.Get_Existing_Record_EndPoint, attendence);
        //        await response.Content.LoadIntoBufferAsync();
        //        string content = response.Content.ReadAsStringAsync().Result;
        //        existingList = JsonConvert.DeserializeObject<List<MultiAtnAnlysis_Response>>(content);

        //    }
        //    catch (Exception exp)
        //    {
        //        _checkIfExceptionReturn = true;
        //        existingList = new List<MultiAtnAnlysis_Response>();
        //    }

        //    return existingList;
        //}

        //public async Task<InShift> GetShift(ManualAttendence req)
        //{
        //    _checkIfExceptionReturn = false;
        //    InShift att = new InShift();
        //    try
        //    {
        //        var response = await _httpClient.PostAsJsonAsync(TokenEndpoints.Get_Shift_EndPoint, req);
        //        await response.Content.LoadIntoBufferAsync();
        //        string content = response.Content.ReadAsStringAsync().Result;
        //        att = JsonConvert.DeserializeObject<InShift>(content);

        //    }
        //    catch (Exception exp)
        //    {
        //        _checkIfExceptionReturn = true;
        //        att = new InShift();
        //    }

        //    return att;
        //}

        //public async Task<MultiAtnAnlysis_Response> InOut(ManualAttendence attendence)
        //{
        //    _checkIfExceptionReturn = false;
        //    MultiAtnAnlysis_Response att = new MultiAtnAnlysis_Response();

        //    try
        //    {
        //        var response = await _httpClient.PostAsJsonAsync(TokenEndpoints.Put_In_EndPoint, attendence);
        //        await response.Content.LoadIntoBufferAsync();
        //        string content = response.Content.ReadAsStringAsync().Result;
        //        att = JsonConvert.DeserializeObject<MultiAtnAnlysis_Response>(content);

        //    }
        //    catch (Exception exp)
        //    {
        //        _checkIfExceptionReturn = true;
        //        att = new MultiAtnAnlysis_Response();
        //    }

        //    return att;
        //}

        //public async Task UpdateRecord(UpdateAttendence attendence)
        //{
        //    _checkIfExceptionReturn = false;


        //    try
        //    {
        //        await _httpClient.PostAsJsonAsync(TokenEndpoints.Update_EndPoint, attendence);


        //    }
        //    catch (Exception exp)
        //    {
        //        _checkIfExceptionReturn = true;
        //    }


        //}

        //public async Task<MultiAtnAnlysis_Response> CreateManualAttendence(AddManualAdt attendence)
        //{
        //    _checkIfExceptionReturn = false;

        //    MultiAtnAnlysis_Response list = new MultiAtnAnlysis_Response();

        //    try
        //    {
        //        var response = await _httpClient.PostAsJsonAsync(TokenEndpoints.Put_Manual_Attendence_EndPoint, attendence);
        //        await response.Content.LoadIntoBufferAsync();
        //        string content = response.Content.ReadAsStringAsync().Result;
        //        list = JsonConvert.DeserializeObject<MultiAtnAnlysis_Response>(content);

        //    }
        //    catch (Exception exp)
        //    {
        //        _checkIfExceptionReturn = true;

        //    }

        //    return list;
        //}

        //public async Task<UserPermission> GetUserPermission(UserPermission obj)
        //{
        //    _checkIfExceptionReturn = false;

        //    UserPermission usrper = new UserPermission();

        //    try
        //    {
        //        var response = await _httpClient.PostAsJsonAsync(TokenEndpoints.User_Permission_EndPoint, obj);
        //        await response.Content.LoadIntoBufferAsync();
        //        string content = response.Content.ReadAsStringAsync().Result;
        //        usrper = JsonConvert.DeserializeObject<UserPermission>(content);

        //    }
        //    catch (Exception exp)
        //    {
        //        _checkIfExceptionReturn = true;

        //    }

        //    return usrper;
        //}

        public async Task<IList<LeaveDetails>> GetAlreadyAppliedLeaves()
        {
            _checkIfExceptionReturn = false;

            IList<LeaveDetails> lev_list = new List<LeaveDetails>();
            LoggedUsers usr = new LoggedUsers();
            try
            {
                _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJRCI6Ikxhc2l0aGEuQkwiLCJuYmYiOjE2NzE1MDk3MTQsImV4cCI6MTY3MTUxMDAxNCwiaWF0IjoxNjcxNTA5NzE0fQ.ZpSd6fUsDPNFyDSsm8e-RdS0IrYp03A6dAV7BIn0HBk");
                var response = await _httpClient.PostAsJsonAsync(TokenEndpoints.Get_Already_Applied_Leave_EndPoint, usr);
                await response.Content.LoadIntoBufferAsync();
                string content = response.Content.ReadAsStringAsync().Result;
                lev_list = JsonConvert.DeserializeObject<List<LeaveDetails>>(content);

            }
            catch (Exception exp)
            {
                _checkIfExceptionReturn = true;

            }

            return lev_list;
        }
        public async Task<int> GetLeaveTrnTypeDetails(LeaveTrnTypeDetails slh)
        {
            _checkIfExceptionReturn = false;

            int key = 0;
            try
            {
                var response = await _httpClient.PostAsJsonAsync(TokenEndpoints.Get_LeaveTrnTypeDetails_EndPoint, slh);
                await response.Content.LoadIntoBufferAsync();
                string content = response.Content.ReadAsStringAsync().Result;
                key = JsonConvert.DeserializeObject<int>(content);

            }
            catch (Exception exp)
            {
                _checkIfExceptionReturn = true;

            }

            return key;
        }
        public async Task<UserDetails> GetReportingPerson(UserDetails req)
        {
            _checkIfExceptionReturn = false;

            UserDetails user = new UserDetails();
            try
            {
                var response = await _httpClient.PostAsJsonAsync(TokenEndpoints.Retrive_Reporting_Person_EndPoint, req);
                await response.Content.LoadIntoBufferAsync();
                string content = response.Content.ReadAsStringAsync().Result;
                user = JsonConvert.DeserializeObject<UserDetails>(content);

            }
            catch (Exception exp)
            {
                _checkIfExceptionReturn = true;

            }

            return user;
        }
        public async Task<decimal> GetLeaveTypeByCompany(UserDetails usr)
        {
            _checkIfExceptionReturn = false;
            decimal max_leave_hour = 0;
            try
            {
                var response = await _httpClient.PostAsJsonAsync(TokenEndpoints.Get_Leave_Type_By_Company_EndPoint, usr);
                await response.Content.LoadIntoBufferAsync();
                string content = response.Content.ReadAsStringAsync().Result;
                max_leave_hour = JsonConvert.DeserializeObject<decimal>(content);

            }
            catch (Exception exp)
            {
                _checkIfExceptionReturn = true;

            }

            return max_leave_hour;
        }
        public async Task<IList<LeaveSummary>> LoadLeaveSummary(LeaveDetails levDet)
        {
            _checkIfExceptionReturn = false;
            IList<LeaveSummary> leaves = new List<LeaveSummary>();
            try
            {
                var response = await _httpClient.PostAsJsonAsync(TokenEndpoints.Get_Leave_Summary_EndPoint, levDet);
                await response.Content.LoadIntoBufferAsync();
                string content = response.Content.ReadAsStringAsync().Result;
                leaves = JsonConvert.DeserializeObject<IList<LeaveSummary>>(content);

            }
            catch (Exception exp)
            {
                _checkIfExceptionReturn = true;

            }

            return leaves;
        }
        public async Task<int> GetMultiApproval(MultiApprovalDetails multiApproval)
        {
            _checkIfExceptionReturn = false;
            int multiApprovalKey = 0;
            try
            {
                var response = await _httpClient.PostAsJsonAsync(TokenEndpoints.Get_MultiApproval_EndPoint, multiApproval);
                await response.Content.LoadIntoBufferAsync();
                string content = response.Content.ReadAsStringAsync().Result;
                multiApprovalKey = JsonConvert.DeserializeObject<int>(content);

            }
            catch (Exception exp)
            {
                _checkIfExceptionReturn = true;
            }

            return multiApprovalKey;
        }

        public async Task ApplyLeave(Leaverequest req)
        {
            _checkIfExceptionReturn = false;

            try
            {
                await _httpClient.PostAsJsonAsync(TokenEndpoints.Apply_Leave_EndPoint, req);
            }
            catch (Exception exp)
            {
                _checkIfExceptionReturn = true;

            }


        }
        public async Task DeleteLeave(LeaveDetails req)
        {
            _checkIfExceptionReturn = false;

            try
            {
                await _httpClient.PostAsJsonAsync(TokenEndpoints.Delete_Leave_EndPoint, req);
            }
            catch (Exception exp)
            {
                _checkIfExceptionReturn = true;

            }
        }
        public async Task<int> SelectLeaveCheck(LeaveCheck req)
        {
            _checkIfExceptionReturn = false;
            int LevTrnKy = 0;
            try
            {
                var response = await _httpClient.PostAsJsonAsync(TokenEndpoints.SelectLeaveCheck_EndPoint, req);
                await response.Content.LoadIntoBufferAsync();
                string content = response.Content.ReadAsStringAsync().Result;
                LevTrnKy = JsonConvert.DeserializeObject<int>(content);

            }
            catch (Exception exp)
            {
                _checkIfExceptionReturn = true;
            }

            return LevTrnKy;
        }

        public async Task<IList<LeaveDetails>> LeaveFilter(Leaverequest req)
        {
            _checkIfExceptionReturn = false;
            IList<LeaveDetails> _leaveList = new List<LeaveDetails>();
            try
            {
                var response = await _httpClient.PostAsJsonAsync(TokenEndpoints.Leave_Filter_EndPoint, req);
                await response.Content.LoadIntoBufferAsync();
                string content = response.Content.ReadAsStringAsync().Result;
                _leaveList = JsonConvert.DeserializeObject<List<LeaveDetails>>(content);

            }
            catch (Exception exp)
            {
                _checkIfExceptionReturn = true;

            }

            return _leaveList;
        }

        public async Task ChangeLeaveStatus(LeaveStatusChange req)
        {
            _checkIfExceptionReturn = false;

            try
            {
                await _httpClient.PostAsJsonAsync(TokenEndpoints.Change_Leave_Status_EndPoint, req);
            }
            catch (Exception exp)
            {
                _checkIfExceptionReturn = true;

            }


        }

        //public async Task<EmployeeModel> LoadEmployeeDetails()
        //{
        //    _checkIfExceptionReturn = false;
        //    EmployeeModel _emp = new EmployeeModel();

        //    try
        //    {
        //        var response = await _httpClient.PostAsJsonAsync(TokenEndpoints.Get_Employee_Details_EndPoint, _emp);
        //        await response.Content.LoadIntoBufferAsync();
        //        string content = response.Content.ReadAsStringAsync().Result;
        //        _emp = JsonConvert.DeserializeObject<EmployeeModel>(content);

        //    }
        //    catch (Exception exp)
        //    {
        //        _checkIfExceptionReturn = true;

        //    }

        //    return _emp;
        //}

        //public async Task<IList<PaySlipDetails>> GeneratePaySlip(SalaryHistory req)
        //{
        //    _checkIfExceptionReturn = false;
        //    IList<PaySlipDetails> _paySlip = new List<PaySlipDetails>();

        //    try
        //    {
        //        var response = await _httpClient.PostAsJsonAsync(TokenEndpoints.Generate_Payslip_EndPoint, req);
        //        await response.Content.LoadIntoBufferAsync();
        //        string content = response.Content.ReadAsStringAsync().Result;
        //        _paySlip = JsonConvert.DeserializeObject<List<PaySlipDetails>>(content);

        //    }
        //    catch (Exception exp)
        //    {
        //        _checkIfExceptionReturn = true;

        //    }

        //    return _paySlip;
        //}


        public bool IsExceptionthrown()
        {
            if (_checkIfExceptionReturn)
                return true;
            return false;
        }
    }
}



//You Are not Entitle For This Leave Type This Leave will be considered as No Pay
