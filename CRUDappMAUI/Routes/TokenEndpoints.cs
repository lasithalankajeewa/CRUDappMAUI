using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDappMAUI.Routes
{
    public static class TokenEndpoints
    {
        public static string Get = "api/identity/token";
        public static string Refresh = "api/identity/token/refresh";

        public static string AuthenticateURL = BaseEndpoint.BaseURL + "Authentication/Authenticate";
        public static string CompanyListingEndPoint = BaseEndpoint.BaseURL + "Authentication/GetUserCompanies";
        public static string CompanyDetailsEndpoint = BaseEndpoint.BaseURL + "Company/GetCompanyInformation";
        public static string CompanySelectedEndPoint = BaseEndpoint.BaseURL + "Authentication/UpdateSelectedCompany";
        public static string OrderSaveEndpoint = BaseEndpoint.BaseURL + "Order/CreateGenericOrder";
        public static string FindOrder = BaseEndpoint.BaseURL + "Order/FindOrders";
        public static string LoadOrderEndPoint = BaseEndpoint.BaseURL + "Order/OpenOrder";
        public static string LoadOrderEndPointFromQuotation = BaseEndpoint.BaseURL + "Order/OpenQuotation";
        public static string OpenQuotationAsSalesOrderEndPoint = BaseEndpoint.BaseURL + "Order/LoadOrder";
        public static string FindFromQuotation = BaseEndpoint.BaseURL + "Order/GetFromQuotation";
        public static string ItemRateEndPoint = BaseEndpoint.BaseURL + "Item/GetItemRateEx";
        public static string GetItemByItemCodeEndPoint = BaseEndpoint.BaseURL + "Item/GetItemByItemCode";
        public static string openReportEndPoint = BaseEndpoint.BaseURL + "Report/OpenReports";
        public static string HtmlToPdfReportEndPoint = BaseEndpoint.BaseURL + "Report/HtmlToPdf";
        public static string CompanyReportInformationEndPoint = BaseEndpoint.BaseURL + "Company/GetCompanyInformation";
        public static string OrderEditEndpoint = BaseEndpoint.BaseURL + "Order/UpdateGenericOrder";
        public static string TransactionSaveEndpoint = BaseEndpoint.BaseURL + "Transaction/saveTransaction";
        public static string LoadOrderApprovalDetails = BaseEndpoint.BaseURL + "Order/LoadOrderApprovals";
        public static string UpdateOrderApproval = BaseEndpoint.BaseURL + "Order/InsertUpdateApprovals";
        public static string StockAsAtEndpoint { get; set; } = BaseEndpoint.BaseURL + "Transaction/GetStockAsAtByLocation";
        public static string FindTransaction = BaseEndpoint.BaseURL + "Transaction/FindTransaction";
        public static string GetPriceListEndPoint = BaseEndpoint.BaseURL + "Transaction/PriceList";
        public static string GetAccountMapping = BaseEndpoint.BaseURL + "Account/GetAccMappingByPaymentType";
        public static string OpenTransaction = BaseEndpoint.BaseURL + "Transaction/OpenTransaction";
        public static string ReadFromTransaction = BaseEndpoint.BaseURL + "Transaction/ReadFromTransaction";
        public static string SaveAccountRecieptURL = BaseEndpoint.BaseURL + "Transaction/SaveAccountReciept";
        public static string ItemImageRequest = BaseEndpoint.BaseURL + "Product/GetItemImage";
        public static string CashDenominationRead = BaseEndpoint.BaseURL + "Transaction/GetDenomination";
        public static string SaveDenominationEndpint = BaseEndpoint.BaseURL + "Transaction/SaveDenomination";
        public static string LoadTransactionApprovalDetails = BaseEndpoint.BaseURL + "Transaction/LoadTransactionApprovals";
        public static string UpdateTransactionApproval = BaseEndpoint.BaseURL + "Transaction/InsertUpdateApprovals";

        public static string GetBookingList = BaseEndpoint.BaseURL + "Booking/GetBookingList";
        public static string GetVehicleDetails = BaseEndpoint.BaseURL + "Booking/GetVehicleDetails";
        public static string GetBookingItmDetails = BaseEndpoint.BaseURL + "Booking/GetBookingItmDetails";
        //public static string GetBookingCusAdrDetails = BaseEndpoint.BaseURL + "Booking/GetBookingCusAdrDetails";
        public static string GetInsertUpdateBooking = BaseEndpoint.BaseURL + "Booking/InsertUpdateBooking";
        public static string TabDetails = BaseEndpoint.BaseURL + "Booking/GetTabDetails";
        public static string CreateNewServiceType = BaseEndpoint.BaseURL + "Booking/CreateServiceType";
        public static string InsertServiceType = BaseEndpoint.BaseURL + "Booking/InsertServiceType";

        public static string GetBookedCustomerDetails = BaseEndpoint.BaseURL + "BookingModule/GetBookedCustomerDetails";

        public static string GetProfileList = BaseEndpoint.BaseURL + "ProjectProfileMobile/GetProfileList";
        public static string UpdateProfile = BaseEndpoint.BaseURL + "ProjectProfileMobile/UpdateProfile";
        public static string Insertprofile = BaseEndpoint.BaseURL + "ProjectProfileMobile/InsertProfile";
        public static string UpdateItem = BaseEndpoint.BaseURL + "ItemProfileMobile/UpdateItemList";
        public static string InsertItem = BaseEndpoint.BaseURL + "ItemProfileMobile/InsertItemList";
        public static string GetItemProfileSelectList = BaseEndpoint.BaseURL + "ItemProfileMobile/GetItemList";
        public static string GetAccountProfileList = BaseEndpoint.BaseURL + "Profile/GetProfileList";
        public static string InsertAccountProfileItem = BaseEndpoint.BaseURL + "Profile/InsertAccountRecord";
        public static string UpdateAccountProfile = BaseEndpoint.BaseURL + "Account/UpdateAccount";

        public static string GetLocationViseStocks = BaseEndpoint.BaseURL + "Chart/GetStockList";
        public static string GetSalesHeaderDetails = BaseEndpoint.BaseURL + "Chart/GetSalesDetails";
        public static string GetSalesByLocationEndPoint = BaseEndpoint.BaseURL + "Chart/GetLocationWiseSales";
        public static string GetSalesByLocationRepEndPoint = BaseEndpoint.BaseURL + "Chart/GetLocationWiseSalesRep";
        public static string GetActualVsBudgetedIncomeEndPoint = BaseEndpoint.BaseURL + "Chart/GetActualVsBudgetedIncomeDetails";
        public static string GPft_NetPft_MarginEndPoint = BaseEndpoint.BaseURL + "Chart/Get_Gprf_Netprf_Details";
        public static string Get_Debtors_Age_Analysis_EndPoint = BaseEndpoint.BaseURL + "Chart/Get_Debtors_Ages";
        public static string Get_Creditors_Age_Analysis_EndPoint = BaseEndpoint.BaseURL + "Chart/Get_Creditors_Ages";
        public static string Get_Debtors_Age_Analysis_Overdue_EndPoint = BaseEndpoint.BaseURL + "Chart/Get_Debtors_Ages_Overdue";
        public static string Get_Creditors_Age_Analysis_Overdue_EndPoint = BaseEndpoint.BaseURL + "Chart/Get_Creditors_Ages_Overdue";
        public static string GPft_NetPft_DT_EndPoint = BaseEndpoint.BaseURL + "Chart/Get_Gprf_Netprf_Details_DT";
        public static string Get_Debtors_DT_EndPoint = BaseEndpoint.BaseURL + "Chart/Get_Debtors_Ages_DT";
        public static string Get_Creditors_DT_EndPoint = BaseEndpoint.BaseURL + "Chart/Get_Creditors_Ages_DT";
        public static string Get_Debtors_Overdue_DT_EndPoint = BaseEndpoint.BaseURL + "Chart/Get_Debtors_Ages_Overdue_DT";
        public static string Get_Creditors_Overdue_DT_EndPoint = BaseEndpoint.BaseURL + "Chart/Get_Creditors_Ages_Overdue_DT";
        public static string Get_Debtor_DT_Transaction_Details_EndPoint = BaseEndpoint.BaseURL + "Chart/Get_Debtors_Ages_DT_Transaction_Details";
        public static string Get_User_Details_EndPoint = BaseEndpoint.BaseURL + "HR/GetEmployeeDetails";
        public static string Get_Existing_Record_EndPoint = BaseEndpoint.BaseURL + "HR/MultiAtnAnlysis";
        public static string Put_In_EndPoint = BaseEndpoint.BaseURL + "HR/In";
        public static string Get_Shift_EndPoint = BaseEndpoint.BaseURL + "HR/GetShiftDetails";
        public static string Update_EndPoint = BaseEndpoint.BaseURL + "HR/UpdateRecord";
        public static string Put_Manual_Attendence_EndPoint = BaseEndpoint.BaseURL + "HR/AddManualAttendenceInOut";
        public static string User_Permission_EndPoint = BaseEndpoint.BaseURL + "Company/GetUserPermissionUnderCompany";

        public static string Get_Already_Applied_Leave_EndPoint = BaseEndpoint.BaseURL + "HR/GetAlreadyAppliedLeaves";
        public static string Get_LeaveTrnTypeDetails_EndPoint = BaseEndpoint.BaseURL + "HR/RetriveLeaveTrnTypeDetails";
        public static string Get_Short_Leave_Key_EndPoint = BaseEndpoint.BaseURL + "HR/RetriveShortLeaveKey";
        public static string Get_Leave_Type_By_Company_EndPoint = BaseEndpoint.BaseURL + "HR/RetriveLeaveTypeByCompany";
        public static string Get_Leave_Summary_EndPoint = BaseEndpoint.BaseURL + "HR/LoadLeaveSummary";
        public static string Get_MultiApproval_EndPoint = BaseEndpoint.BaseURL + "HR/CheckMultiApproval";
        public static string Apply_Leave_EndPoint = BaseEndpoint.BaseURL + "HR/ApplyLeave";
        public static string Retrive_Reporting_Person_EndPoint = BaseEndpoint.BaseURL + "HR/RetriveReportingPerson";
        public static string SelectLeaveCheck_EndPoint = BaseEndpoint.BaseURL + "HR/SelectLeaveCheck";
        public static string Delete_Leave_EndPoint = BaseEndpoint.BaseURL + "HR/DeleteLeave";
        public static string Leave_Filter_EndPoint = BaseEndpoint.BaseURL + "HR/FilterLeaves";
        public static string Change_Leave_Status_EndPoint = BaseEndpoint.BaseURL + "HR/LevTrnAprInsert";
        public static string Get_Employee_Details_EndPoint = BaseEndpoint.BaseURL + "HR/GetEmployeeProfile";
        public static string Generate_Payslip_EndPoint = BaseEndpoint.BaseURL + "HR/GeneratePaySlip";
        public static string PaySlip_EndPoint = BaseEndpoint.BaseURL + "HR/PrintPaySlip";
        public static string CreateNewAddressURL = BaseEndpoint.BaseURL + "Address/CreateNewAddress";
        public static string UserInfoReadURL = BaseEndpoint.BaseURL + "Authentication/GetCompanyInformation";
        public static string ItemImageReadURL = BaseEndpoint.BaseURL + "Item/GetItemImage";
        public static string Save_Trn_Hdr_From_Location_EndPoint = BaseEndpoint.BaseURL + "ItemTransfer/TrnHeaderSaveFromLocation";
        public static string Save_Trn_Hdr_To_Location_EndPoint = BaseEndpoint.BaseURL + "ItemTransfer/TrnHeaderSaveToLocation";
        public static string Get_Data_EndPoint = BaseEndpoint.BaseURL + "ItemTransfer/GetScannedData";
        public static string Get_Invoice_Data_EndPoint = BaseEndpoint.BaseURL + "ItemTransfer/GetScannedInvoiceData";
        public static string Save_Line_EndPoint = BaseEndpoint.BaseURL + "ItemTransfer/LineItemSave";
        public static string Find_ItmTrn_EndPoint = BaseEndpoint.BaseURL + "ItemTransfer/FindItemTransfers";
        public static string Refresh_Header_EndPoint = BaseEndpoint.BaseURL + "ItemTransfer/ItemTransferSelect";
        public static string Update_Header_For_Out_EndPoint = BaseEndpoint.BaseURL + "ItemTransfer/TrnHeaderUpdateOut";
        public static string Update_Header_For_In_EndPoint = BaseEndpoint.BaseURL + "ItemTransfer/TrnHeaderUpdateIn";
        public static string Update_Line_For_Out_EndPoint = BaseEndpoint.BaseURL + "ItemTransfer/LineItemUpdateForOut";
        public static string Update_Line_For_In_EndPoint = BaseEndpoint.BaseURL + "ItemTransfer/LineItemUpdateForIn";
        public static string FIFO_Posting_EndPoint = BaseEndpoint.BaseURL + "ItemTransfer/FIFO";
        public static string Refresh_ItemTransfer_Invoice_EndPoint = BaseEndpoint.BaseURL + "ItemTransfer/ItemTransferSelectForInvoice";
        public static string ItemTrnasactionSerialsURL = BaseEndpoint.BaseURL + "Transaction/GetSerialNumbersForTransactionLineItem";
        public static string ItemTransferValidationEndpoint = BaseEndpoint.BaseURL + "ItemTransfer/LineItemValidationBySerNo";
        public static string InvoiceItemTransferValidationEndpoint = BaseEndpoint.BaseURL + "ItemTransfer/InvoiceValidationBySerNo";
        public static string GetInvoiceItemsSerialNoList = BaseEndpoint.BaseURL + "ItemTransfer/RetriviewSerialNoList";
        public static string CreateItemTransfer_EndPoint = BaseEndpoint.BaseURL + "ItemTransfer/CreateItemTransfer";
        public static string Update_ItmTransfer_EndPoint = BaseEndpoint.BaseURL + "ItemTransfer/UpdateItemTransfer";
        public static string ItemTrnasactionSerials = BaseEndpoint.BaseURL + "Transaction/GetSerialNumbersForTransactionLineItem";
        public static string FileUploadEndPoint = BaseEndpoint.BaseURL + "Document/UploadFile";
        public static string GetBase64DocumentsEndPoint = BaseEndpoint.BaseURL + "Document/GetBase64Doc";

        //lnd

        public static string InvoiceBySerial = BaseEndpoint.BaseURL + "Transaction/InvoiceFromSerianNumber";
        public static string TotalPayedRequestURL = BaseEndpoint.BaseURL + "Transaction/GetTransactionTotalPayed";
        public static string SaveItemSerialURL = BaseEndpoint.BaseURL + "Transaction/SaveItemSerialNumber";
        public static string CodeBaseDetailRequest = BaseEndpoint.BaseURL + "CodeBase/GetCodeDetail";
        public static string SaveAccountRecieptURLEx = BaseEndpoint.BaseURL + "Transaction/SaveAccountRecieptEx";

        //carmart
        public static string SearchVehicleDetailsEndpoint = BaseEndpoint.BaseURL + "WorkShopManagement/SearchVehicle";
        public static string GetJobHistoryDetailsEndpoint = BaseEndpoint.BaseURL + "WorkShopManagement/getJobHistories";
        public static string CreateProjectEndPoint = BaseEndpoint.BaseURL + "Project/projectHeaderInsert";
        public static string SelectCarMartOngoingProjectDetails = BaseEndpoint.BaseURL + "WorkShopManagement/getCarProgessingProjectDetails";
        public static string SaveWorkOrderEndPoint = BaseEndpoint.BaseURL + "WorkShopManagement/createWorkOrder";
        public static string UpdateWorkOrderEndpoint = BaseEndpoint.BaseURL + "WorkShopManagement/updateWorkOrder";
        public static string OpenWorkorderEndPoint = BaseEndpoint.BaseURL + "WorkShopManagement/openWorkOrder";
        public static string GetRecentBookingDetailsEndPoint = BaseEndpoint.BaseURL + "WorkShopManagement/getRecentBookingDetails";
        public static string SaveWorkOrderTransactionEndpoint = BaseEndpoint.BaseURL + "WorkShopManagement/saveTransactionOfWorkOrder";
        public static string OpenWorkOrderTransactionEndpoint = BaseEndpoint.BaseURL + "WorkShopManagement/openTransactionOfWorkOrder";
        public static string GetAddressByUsrKyEndPoint = BaseEndpoint.BaseURL + "Address/GetAddressByUsrKy";
        public static string WorkShopValidationEndpoint = BaseEndpoint.BaseURL + "WorkShopManagement/validationWorkOrderEndPoint";
        public static string GetAvailableStockEndpoint = BaseEndpoint.BaseURL + "Item/getAvailableStock";
        //public static string GetVehicleDetailsByregNoEndpoint = BaseEndpoint.BaseURL + "WorkShopManagement/getVehicleByRegNo";

        //carmart insurence
        public static string SaveIRNWorkOrderEndPoint = BaseEndpoint.BaseURL + "WorkShopManagement/createIRNWorkOrder";
        public static string EditIRNWorkOrderEndPoint = BaseEndpoint.BaseURL + "WorkShopManagement/updateIRNWorkOrder";
        public static string GetIRNDetailsEndPoint = BaseEndpoint.BaseURL + "WorkShopManagement/getIRNByStatus";

        //carmart--Add new Customer
        public static string CreateCustomer = BaseEndpoint.BaseURL + "Address/createCustomer";
        public static string CreateCustomerValidation = BaseEndpoint.BaseURL + "Address/customerValidation";
        public static string GetVehicleDetailsByregNoEndpoint = BaseEndpoint.BaseURL + "WorkShopManagement/getVehicleByRegNo";



        //OrderHub
        public static string GetOrderStatus = BaseEndpoint.BaseURL + "Order/GetOrderStatus";
        public static string PartnerOrderCount = BaseEndpoint.BaseURL + "Order/GetPartnerCountByStatus";
        public static string GetAllPartnerOrders = BaseEndpoint.BaseURL + "Order/GetAllPartnerOrders";
        public static string GetAPIInfo = BaseEndpoint.BaseURL + "Order/GetAPIDetails";
        public static string GetAPIEndPoints = BaseEndpoint.BaseURL + "Order/GetOrderEndPoints";
        public static string GetLastSyncTime = BaseEndpoint.BaseURL + "Order/GetLastOrderSyncTime";
        public static string GetOrderStatusByPartnerStatus = BaseEndpoint.BaseURL + "Order/GetOrderStatusByPartnerStatus";
        public static string SavePartnerOrder = BaseEndpoint.BaseURL + "Order/GetOrdersFromOrderPlatforms";
        public static string GetItemsByItemCode = BaseEndpoint.BaseURL + "Order/GetItemsByItemCode";
        public static string CheckAdvanceAnalysisAvailability = BaseEndpoint.BaseURL + "Address/CheckAdvanceAnalysisAvailability";
        public static string CreateAdvanceAnalysis = BaseEndpoint.BaseURL + "Address/CreateAdvanceAnalysis";
        public static string GetPartnerOrdersByOrderKy = BaseEndpoint.BaseURL + "Order/GetPartnerOrdersByOrderKy";
        public static string InsertLastOrderSync = BaseEndpoint.BaseURL + "Order/InsertLastOrderSync";

    }
}
