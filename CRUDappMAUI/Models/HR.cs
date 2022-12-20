using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDappMAUI.Models
{
    public class HR
    {
    }


    public class LoggedUsers
    {
        public int UsrKy { get; set; }
        public string UsrId { get; set; }
    }

    public class UserDetails
    {
        public string AdrNm { get; set; }
        public int AdrKy { get; set; }
        public DateTime DOB { get; set; }
        public string AdrFullNm { get; set; }
    }

    public class MultiAtnAnlysis
    {
        public long EmpKy { get; set; }
        public string FDt { get; set; }
        public string TDt { get; set; }
        public byte Chk { get; set; }
        public int PrjKy { get; set; }
        public int TaskKy { get; set; }

        public MultiAtnAnlysis()
        {
            FDt = DateTime.Now.ToString("yyyy/MM/dd");
            TDt = DateTime.Now.ToString("yyyy/MM/dd");
            Chk = 0;
            PrjKy = 1;
            TaskKy = 1;
        }
    }

    public class MultiAtnAnlysis_Response
    {
        public int MultiAtnDetKy { get; set; }
        public int AtnDetKy { get; set; }
        public DateTime? InDtm { get; set; }
        public DateTime? OutDtm { get; set; }
        public double INLatitude { get; set; }
        public double INLongitude { get; set; }
        public double OutLatitude { get; set; }
        public double OutLongitude { get; set; }
        public CodeBaseResponse Location { get; set; }
        public double TTlMint { get; set; }

        public MultiAtnAnlysis_Response()
        {

        }

        public TimeSpan GetWorkHours()
        {


            if (InDtm != null && OutDtm != null)
            {
                return OutDtm.Value.Subtract(InDtm.Value);

            }
            else
            {
                return TimeSpan.Zero;
            }


        }



    }

    public class InRequest
    {
        public long EmpKy { get; set; }
        public string Date { get; set; } = DateTime.Now.ToString("yyyy/MM/dd");
    }

    public class InShift
    {
        public int ShiftKy { get; set; }
        public int DedMinute { get; set; }
        public int isHoliday { get; set; }
    }

    public class ManualAttendence : InRequest
    {
        public int ShiftKy { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public CodeBaseResponse Location { get; set; }
        public int MultiAtnDetKy { get; set; }
        public int IsHoliday { get; set; }
        public int IsIn { get; set; }
        public int IsOut { get; set; }
        public int IsoutWithoutIn { get; set; }
        public UpdateAttendence selectedAttendence { get; set; }
        public ManualAttendence()
        {
            Latitude = 0.00;
            Longitude = 0.00;
            MultiAtnDetKy = 1;
            IsIn = 0;
            IsOut = 0;
            IsoutWithoutIn = 0;
            ShiftKy = 0;
            IsHoliday = 0;
            MultiAtnDetKy = 1;
            selectedAttendence = new UpdateAttendence();
            Location = new CodeBaseResponse();
        }

    }

    public class UpdateAttendence
    {
        public DateTime? InDtm { get; set; }
        public DateTime? OutDtm { get; set; }
        public int MultiAtnDetKy { get; set; }
        public int AtnDetKy { get; set; }
        public byte IsManual { get; set; }
        public byte IsOutManual { get; set; }

        public UpdateAttendence()
        {
            IsManual = 0;
            IsOutManual = 0;
        }
    }

    public class AddManualAdt
    {
        public long EmpKy { get; set; }
        public int ShiftKy { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public CodeBaseResponse Location { get; set; }
        public int MultiAtnDetKy { get; set; }
        public int IsHoliday { get; set; }
        public DateTime? InDtm { get; set; }
        public DateTime? OutDtm { get; set; }
        public DateTime? AtnDt { get; set; }
        public AddManualAdt()
        {
            AtnDt = DateTime.Now;
            InDtm = null;
            OutDtm = null;
        }

    }

}
