using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDappMAUI.Models
{
    public class BaseResponse
    {
        public bool IsDefault { get; set; }

        public bool IsMust { get; set; }

        public static bool IsValidData(BaseResponse response)
        {
            if (response == null)
            {
                return false;
            }

            if (response.GetType() == typeof(CodeBaseResponse))
            {
                return (response as CodeBaseResponse).CodeKey > 10;
            }


            if (response.GetType() == typeof(ItemResponse))
            {
                return (response as ItemResponse).ItemKey > 10;
            }


            if (response.GetType() == typeof(AddressResponse))
            {
                return (response as AddressResponse).AddressKey > 10;
            }


            if (response.GetType() == typeof(AccountResponse))
            {
                return (response as AccountResponse).AccountKey > 10;
            }



            return false;

        }
        public static long GetKeyValue(BaseResponse response)
        {
            if (response == null)
            {
                return 1;
            }

            if (response is CodeBaseResponse)
            {
                return (response as CodeBaseResponse).CodeKey;
            }
            if (response is AddressResponse)
            {
                return (response as AddressResponse).AddressKey;
            }
            if (response is AccountResponse)
            {
                return (response as AccountResponse).AccountKey;
            }
            if (response is UnitResponse)
            {
                return (response as UnitResponse).UnitKey;
            }
            if (response is ItemResponse)
            {
                return (response as ItemResponse).ItemKey;
            }

            if (response is ProjectResponse)
            {
                return (response as ProjectResponse).ProjectKey;
            }

            return 1;
        }


        public IDictionary<string, object> AddtionalData { get; set; }

        public BaseResponse()
        {
            AddtionalData = new Dictionary<string, object>();
        }

        public string Base64ImageDocument { get; set; } = "";
    }
    public class ComboRequestDTO
    {
        public long RequestingElementKey { get; set; } = 1;
        public string RequestingURL { get; set; } = "";
        public IDictionary<string, object> AddtionalData { get; set; } = new Dictionary<string, object>();

        public ComboRequestDTO()
        {
            AddtionalData = new Dictionary<string, object>();

        }

        public string SearchQuery { get; set; } = "";

        public bool CancelRead { get; set; }
        public int EntityKey { get; set; } = 1;

    }

    public class CodeBaseResponse : BaseResponse
    {
        public int CodeKey { get; set; } = 1;
        //public string CodeName { get; set; } = "";
        public string ConditionCode { get; set; } = "";
        public string CodeName { get; set; } = "-";
        public string OurCode { get; set; } = "";


        public override string ToString()
        {
            return this.CodeName;
        }

        public string Code { get; set; } = "";

        public int Count { get; set; } = 0;

        public void SeperateServiceType()
        {
            if (CodeKey == 443470)
            {
                AddtionalData["IsKiloWash"] = true;
                AddtionalData["IsCommon"] = false;
            }
            else if (CodeKey == 1 || CodeKey == 431996 || CodeKey == 432173 || CodeKey == 435650)
            {
                AddtionalData["IsCommon"] = true;
                AddtionalData["IsKiloWash"] = false;
            }
            else
            {
                AddtionalData["IsCommon"] = false;
                AddtionalData["IsKiloWash"] = false;
            }
        }

    }
    public class AddressResponse : BaseResponse
    {
        public long AddressKey { get; set; } = 1;

        public string AddressName { get; set; } = "-";

        public override string ToString()
        {
            return this.AddressName;
        }


        public string AddressID { get; set; } = "";

    }

    public class ItemResponse : BaseResponse
    {
        public long ItemKey { get; set; } = 1;
        public string ItemName { get; set; } = "-";

        public decimal Rate { get; set; } = 0;

        public string ItemCode { get; set; } = "";

        public string ItemNameOnly { get; set; } = "";  // Added

        public string ItemCodeOnly { get; set; } = "";  // Added
        public override string ToString()
        {
            if (ItemKey == 1)
            {
                return "-";

            }
            if (ItemName != null)
            {
                return ItemName;
            }
            return "-";
        }

        public CodeBaseResponse ItemCategory1 { get; set; } = new CodeBaseResponse();
        public CodeBaseResponse ItemCategory2 { get; set; } = new CodeBaseResponse();

        public CodeBaseResponse ItemType { get; set; } = new CodeBaseResponse();

        public ItemResponse()
        {
            ItemType = new CodeBaseResponse();
        }


        public bool IsCompensationItem()
        {


            return BaseResponse.IsValidData(ItemType) && ItemType.Code.Equals("CMPMS", StringComparison.InvariantCultureIgnoreCase);

        }

        public bool IsServiceItem()
        {


            return BaseResponse.IsValidData(ItemType) && ItemType.Code.Equals("ServiceItem", StringComparison.InvariantCultureIgnoreCase);

        }

        public bool IsWeightItem()
        {
            return BaseResponse.IsValidData(ItemType) && ItemType.Code.Equals("WI", StringComparison.InvariantCultureIgnoreCase);
        }

        public bool HasUptoTenWeight()
        {
            return !string.IsNullOrEmpty(ItemCodeOnly) && ItemCodeOnly.Equals("WGT-003", StringComparison.InvariantCultureIgnoreCase);
        }


        public bool IsTangibleItem()
        {
            var v = !(IsCompensationItem() || IsServiceItem());
            return v;
        }

    }

    public class ItemCodeResponse : ItemResponse
    {
        public int UnitKey { get; set; } = 1;

        public string UnitName { get; set; } = "";

        public string ItemCodeName { get; set; } = "";

        public decimal TransactionRate { get; set; }

        public decimal DiscountPercentage { get; set; }

        public decimal VAT { get; set; }

        public decimal NBT { get; set; }

        public decimal WHT { get; set; }

        public decimal SVAT { get; set; }

    }


    public class UnitResponse : BaseResponse
    {
        public long UnitKey { get; set; } = 1;

        public string UnitName { get; set; } = "-";

        public override string ToString()
        {
            return this.UnitName;
        }



    }


    


    public class AccountResponse : BaseResponse
    {
        public long AccountKey { get; set; } = 1;

        public string AccountName { get; set; } = "-";
        public string AccountCode { get; set; } = "";

        public override string ToString()
        {
            return this.AccountName;
        }
    }


    public class ProjectResponse : BaseResponse
    {
        public long ProjectKey { get; set; } = 1;

        public string ProjectName { get; set; } = "-";

        public string ProjectId { get; set; } = "-";

        public override string ToString()
        {
            return this.ProjectName;
        }

        public DateTime ExpiryDate { get; set; } = DateTime.Now;

    }



    

    public class PriceListResponse
    {
        public long ItemKey { get; set; } = 1;

        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public string EAN { get; set; }

        public UnitResponse PackUnit { get; set; }

        public UnitResponse LooseUnit { get; set; }
        public decimal LooseUnitPrice { get; set; }
        public decimal PackUnitPrice { get; set; }

        public decimal PackSize { get; set; }

        public ProjectResponse PriceListProject { get; set; }

        public bool CanUsePackUnit()
        {
            return PackUnit != null && PackUnit.UnitKey > 10 && PackSize > 0 && PackUnitPrice > 0;
        }
        public bool CanUseLooseUnit()
        {
            return LooseUnit != null && LooseUnit.UnitKey > 10;
        }

        public bool CanAddToTransaction()
        {
            return (CanUseLooseUnit() || CanUsePackUnit());

        }


        public decimal? GetPriceByUnit(UnitResponse unit)
        {
            decimal? rate = null;
            if (unit != null && unit.UnitKey > 10)
            {

                if (unit.UnitKey == PackUnit.UnitKey && CanUsePackUnit())
                {
                    rate = PackUnitPrice;
                }
                if (unit.UnitKey == LooseUnit.UnitKey && CanUseLooseUnit())
                {
                    rate = LooseUnitPrice;
                }

                if (rate == 0)
                {
                    rate = Math.Max(PackUnitPrice, LooseUnitPrice);
                }

            }


            return rate;

        }


        public IList<UnitResponse> GetComboResponseByPriceList()
        {
            bool DefaultSet = false;
            IList<UnitResponse> list = new List<UnitResponse>();

            list.Add(new UnitResponse());

            if (PackUnit.UnitKey > 10)
            {
                if (PackUnit.UnitKey == DefaultUnitKey)
                {
                    PackUnit.IsDefault = true;
                    DefaultSet = true;
                }
                list.Add(PackUnit);
            }

            if (LooseUnit.UnitKey > 10)
            {
                if (LooseUnit.UnitKey == DefaultUnitKey)
                {
                    LooseUnit.IsDefault = true;
                    DefaultSet = true;
                }
                list.Add(LooseUnit);
            }


            if (!DefaultSet && list.Count > 1)
            {
                list[1].IsDefault = true;
            }

            return list;
        }


        public long DefaultUnitKey { get; set; } = 1;





    }

    //public class UnitComboResponse : BaseResponse
    //{
    //    public long UnitKey { get; set; } = 1;

    //    public string UnitName { get; set; } = "-";

    //}

    public class PriceListRequest
    {
        public long ElementKey { get; set; } = 1;
        public long PreviousKey { get; set; } = 1;
        public long TransactiionTypeKey { get; set; } = 1;
        public long AddressKey { get; set; } = 1;
        public long Code1Key { get; set; } = 1;
        public long ProjectKey { get; set; } = 1;
        public string SearchQuery { get; set; } = "";
    }

    public class AccPaymentMappingRequest
    {
        public CodeBaseResponse Location { get; set; }
        public CodeBaseResponse PayementTerm { get; set; }
        public bool LoadAll { get; set; }
        public long ELementKey { get; set; } = 1;

    }


    public class AccPaymentMappingResponse
    {
        public AccountResponse Account { get; set; }
        public CodeBaseResponse PayementMode { get; set; }

        public AccPaymentMappingResponse()
        {
            Account = new AccountResponse();
            PayementMode = new CodeBaseResponse();
        }

    }

    public class StockAsAtRequest
    {
        public long ItemKey { get; set; }
        public long LocationKey { get; set; }
        public long ElementKey { get; set; } = 1;
        public long ProjectKey { get; set; } = 1;
        public int TrnTypKy { get; set; } = 1;
        public int IsuPrjKy { get; set; } = 1;
        public int IsuLocKy { get; set; } = 1;
        public int TrnUnitKy { get; set; } = 1;

    }

    public class StockAsAtResponse
    {
        public long ItemKey { get; set; }
        public decimal StockAsAt { get; set; }

    }



    public class FindTransactionResponse
    {
        public IList<FindTransactionLineItem> LineItems { get; set; }


        public FindTransactionResponse()
        {
            IList<FindTransactionLineItem> LineItems = new List<FindTransactionLineItem>();
        }
    }


    public class FindTransactionLineItem
    {
        public long TransactionKey { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Prefix { get; set; }
        public string TransactionNumber { get; set; }
        public string DocumentNumber { get; set; }
        public string YourReference { get; set; }
        public CodeBaseResponse Location { get; set; }
        public AddressResponse Address { get; set; }
        public decimal Amount { get; set; }
        public int IsApprove { get; set; } = 1;

    }

    public class TransactionFindRequest
    {

        private DateTime? fromDate = new DateTime(1990, 1, 1);
        public long TransactionKey { get; set; }
        public DateTime? FromDate
        {
            get
            {
                return fromDate;
            }
            set
            {
                fromDate = value;
            }
        }
        public DateTime? ToDate { get; set; } = new DateTime(2990, 1, 1);
        public CodeBaseResponse Prefix { get; set; } = new();
        public CodeBaseResponse ApproveStatus { get; set; } = new();
        public string TransactionNumber { get; set; }
        public string DocumentNumber { get; set; }
        public string YourReference { get; set; }
        public CodeBaseResponse Location { get; set; } = new();
        public AddressResponse Address { get; set; } = new();
        public ProjectResponse Project { get; set; } = new();
        public AccountResponse Suuplier { get; set; } = new();
        public ItemResponse Item { get; set; } = new();
        public int IsRecurrence { get; set; } = 0;
        public int IsPrinted { get; set; } = 0;
        public long ElementKey { get; set; } = 1;

        public CodeBaseResponse PaymentTerm { get; set; }

        public decimal Amount { get; set; }
        public CodeBaseResponse TransactionType { get; set; }

    }

    public class TransactionOpenRequest
    {
        public long TransactionKey { get; set; } = 1;

        public long ElementKey { get; set; } = 1;

    }

    public class RecieptDetailRequest
    {
        public long TransactionKey { get; set; } = 1;
        public long ElementKey { get; set; } = 1;


    }
    public class RecieptDetailResponse
    {
        public string TransactionType { get; set; }
        public string TransactionNumber { get; set; }
        public decimal InvoiceAmaount { get; set; }
        public decimal SetOffAmount { get; set; }
        public decimal TotalSetOffAmount { get; set; }
        public decimal BalanceAmount { get; set; }
        public long CreditAccountTransactioKey { get; set; } = 1;
        public long DebitAccountTransactioKey { get; set; } = 1;
        public CodeBaseResponse PayementTerm { get; set; }
        public AddressResponse RepAddress { get; set; }
        public int LineNumber { get; set; }


    }

    public class AccoutRecieptPayment
    {
        public string TransactionTypeCode { get; set; } = "RECP";
        public long AccountTransactionKey { get; set; } = 1;
        public CodeBaseResponse PaymentTerm { get; set; }
        public long DebitAccountKey { get; set; } = 1;
        public long DebitAddressKey { get; set; } = 1;
        public string DocumentNumber { get; set; } = "";
        public DateTime? PaymentDocDate { get; set; } = DateTime.Now;
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        public decimal Amount { get; set; }
        public long ElementKey { get; set; } = 1;



    }



    

    public class AddressCreateResponse : BaseResponse
    {
        public AddressResponse AddressResponse { get; set; }

        public bool IsSuccess { get; set; }

        public string Message { get; set; }


    }


    public class CompletedUserAuth
    {
        public User AuthenticatedUser { get; set; }
        public Company AuthenticatedCompany { get; set; }

        public CompletedUserAuth()
        {
            this.AuthenticatedCompany = new Company();
            this.AuthenticatedCompany.CompanyKey = 1;
            this.AuthenticatedUser = new User();
            this.AuthenticatedUser.UserKey = 1;
        }
    }

    public class User
    {
        public long UserKey { get; set; }
        public string UserName { get; set; } = "";
        public string Password { get; set; } = "";
        public string UserID { get; set; } = "";
    }

    public class Company
    {
        public int CompanyKey { get; set; }

        public string CompanyName { get; set; } = "";

        public string CompanyCode { get; set; } = "";
    }


    public class ItemTransactionCode
    {
        public long ItemTransactionCodeKey { get; set; } = 1;

        public long ItemTransactionKey { get; set; } = 1;

        public long ControlKey { get; set; } = 1;

        public long CodeBaseKey { get; set; } = 1;



    }


    public class ItemTransactionSerialRequest
    {
        public long ItemTransactionKey { get; set; }
        public int ObjectKey { get; set; } = 1;
    }

    //lnd
    public class CodeBaseResponseExtended : CodeBaseResponse
    {
        public decimal CodeNumber1 { get; set; } = 0;

    }

    public class PaymentModeWiseAmount
    {
        public CodeBaseResponse PaymentMode { get; set; }
        public decimal Amount { get; set; }
        public string PayementDocumentNumber { get; set; }
        public DateTime? PayementDocumentDate { get; set; }

    }

    public class PayementModeReciept
    {
        public IList<PaymentModeWiseAmount> Payements { get; set; }
        public DateTime PayementDate { get; set; }
        public long TransactionKey { get; set; } = 1;
        public string OurCode { get; set; } = "";
        public long ElementKey { get; set; } = 1;
        public long InitiatorElementKey { get; set; } = 1;
        public PayementModeReciept()
        {
            Payements = new List<PaymentModeWiseAmount>();
        }
    }
}
