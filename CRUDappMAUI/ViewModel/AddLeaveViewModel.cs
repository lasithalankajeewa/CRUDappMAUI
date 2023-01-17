
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Maui.Views;
using CRUDappMAUI.Models;
using CRUDappMAUI.Pages;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net;
using System.Windows.Input;

namespace CRUDappMAUI.ViewModel
{
    public partial class AddLeaveViewModel : ObservableObject
    {
        public AddLeaveViewModel()
        {
            
            this.GetLeaveSummery();
            
           
            
        }

        [ObservableProperty]
        ObservableCollection<LeaveSumModel> _LItems;

        [ObservableProperty]
        string _error="";

        [ObservableProperty]
        ObservableCollection<string> _Items;

        [ObservableProperty]
        string _pick1;

        [ObservableProperty]
        int _pick1Index;

        [ObservableProperty]
        int _pick2Index;

        [ObservableProperty]
        int _pick3Index;

        [ObservableProperty]
        string _pick2;

        [ObservableProperty]
        string _pick3;

        [ObservableProperty]
        string _text1;

        [ObservableProperty]
        DateTime _date1 = DateTime.Today;

        [ObservableProperty]
        DateTime _date2 = DateTime.Today;

        [ObservableProperty]
        double _nodays;

        [ObservableProperty]
        bool _firsthalf;

        [ObservableProperty]
        bool _secondhalf;

        [ObservableProperty]
        TimeSpan _time1;

        [ObservableProperty]
        TimeSpan _time2;

        [ObservableProperty]
        bool _time1IsEnabled = false;

        [ObservableProperty]
        bool _time2IsEnabled=false;

        [ObservableProperty]
        TimeSpan _leavehours;

        [ObservableProperty]
        bool _leavehoursIsEnabled=false;

        [ObservableProperty]
        bool _IsPopUp=false;




        int SLBal;
        TimeSpan span;


        public void OnToggleSwitch( bool IsOn)
        {
            Firsthalf = IsOn;
            Secondhalf = !IsOn;
            Nodays += 0.5;

        }

        public void OnToggleSwitch2(bool IsOn)
        {
            Secondhalf = IsOn;
            Firsthalf = !IsOn;
            Nodays += 0.5;

        }

        public void OnDate2Chaged() {
            TimeSpan difference = Date2 - Date1;
            Nodays = difference.Days+1;

        }

        public void OnTime2Chaged()
        {
            span = Time2.Subtract(Time1);
            Leavehours = span;
            if (span.Hours > SLBal)
            {
                ShowPopup2();
            }

        }

        public void OnPickerChanged()
        {
            if (Pick1Index == 2)
            {

                Time1IsEnabled = true;
                Time2IsEnabled = true;
                //LeavehoursIsEnabled = true;
                

            }
            else {

                Time1IsEnabled = false;
                Time2IsEnabled = false;
                LeavehoursIsEnabled = false;
            }


        }

        public string tokn = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6WyJJc2hhbi5EQyIsIklzaGFuLkRDIl0sIm5hbWVpZCI6IklzaGFuLkRDIiwiRmlyc3ROYW1lIjoiSXNoYW4uREMiLCJVc2VySWQiOiJJc2hhbi5EQyIsIkVtYWlsIjoiTm8gRW1haWwiLCJDQ0QiOiJEQyIsInJvbGUiOiJDb21wYW55QXV0aFN1Y2Nlc3MiLCJuYmYiOjE2NzM5MjUxMDUsImV4cCI6MTY3Mzk2ODMwNSwiaWF0IjoxNjczOTI1MTA1fQ.PcDQkyG3o9GFAeqioAeOHk_7_HEpUBrAMR3-2CDXMWs";

        public ICommand ShowPopupCommand { get; }

        private bool ShowPopup()
        {
            var popup = new SortPopup();
            Shell.Current.ShowPopup(popup);
            return true;
        }

        private bool ShowPopup2()
        {
            var popup = new SLPopup();
            Shell.Current.ShowPopup(popup);
            return true;
        }

        int LTTK,LRK;

        [RelayCommand]
        public async void SubmitClicked()
        {
            
            try
            {
                
               

               


                //Set picker values

                

                if (Pick1Index == 0)
                {
                    LTTK = 221698;
                }
                else if (Pick1Index == 1)
                {
                    LTTK = 221681;
                }
                else if (Pick1Index == 2)
                {
                    LTTK = 221680;
                    
                }


                if (Pick2Index == 0)
                {
                    LRK = 310641;
                }
                else if (Pick2Index == 1)
                {
                    LRK = 310640;
                }
                else if (Pick2Index == 2)
                {
                    LRK = 310639;
                }




                Leaverequest insertBody = new Leaverequest();
                insertBody.ObjKy = 1;
                insertBody.EmpKy = 874258;
                CodeBaseResponse lt = new CodeBaseResponse();
                lt.CodeKey = LTTK;

                CodeBaseResponse lr = new CodeBaseResponse();
                lr.CodeKey = LRK;

                insertBody.LeaveType = lt;
                insertBody.LevReason = lr;
                insertBody.LeaveTrnKy = 0;
                insertBody.LeaveTrnTypKy = 221749;
                if (Pick1Index == 2)
                {
                    //insertBody.EftvDt = new DateTime() +  Time1;
                    //insertBody.ToD = new DateTime() + Time2;
                    insertBody.EftvDt = Date1;
                    //insertBody.ToD = Date2;
                    insertBody.ShortLeaveHours = span.Hours;
                }
                else
                {
                    insertBody.EftvDt = Date1;
                    insertBody.ToD = Date2;
                }
                
                insertBody.LevDays = Nodays+1;
                insertBody.IsFirstHalf = Firsthalf;
                insertBody.IsSecondHalf = Secondhalf;
                insertBody.IsAct =1;
                insertBody.AcsLvlKy = 1;
                insertBody.ConFinLvlKy = 1;
                insertBody.ReporterKy = 727795;
                insertBody.Rem = "des";
                insertBody.ReqDate = DateTime.Today;

              

                var client = new RestClient("http://bl360x.com/BLEcomTest/api");
                var request = new RestRequest("/HR/ApplyLeave").AddJsonBody(insertBody);
                request.Method = Method.Post;
                request.AddHeader("Accept", "application/json");

                request.AddHeader("IntegrationID", "1aa6a39b-5f54-4905-880a-a52733fd6105");
                request.AddHeader("Authorization", tokn);
                request.AddHeader("Content-Type", "application/json");

                RestResponse response = await client.PostAsync(request);



                // Check the status code of the response
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Read the response data
                    var responseContent = response.Content.ToString();

                    Debug.WriteLine(responseContent);
                    ShowPopup();
                }
                else
                {
                    Debug.WriteLine("Request failed with status code: " + response.StatusCode);
                }



            }
            catch (Exception ex) { 
            
                Debug.WriteLine(ex.ToString());
            
            }
            

        }

        //get leave summery 
        public async Task<ObservableCollection<LeaveSumModel>> GetLeaveSummery()
        {
            try

            {
                Debug.WriteLine("Leave Summery is running");
                LeaveSummary ls=new LeaveSummary();

                //ls.CompanyId = 156;
                ls.UserKey = 342922;
                ls.EmpKy = 874258;
                ls.Year = "2022/01/01";


               var client = new RestClient("http://bl360x.com/BLEcomTest/api");
                //var client = new RestClient("http://10.0.2.2:62185/api");
                var request = new RestRequest("/HR/LoadLeaveSummary").AddJsonBody(ls);
                request.Method = Method.Post;
                request.AddHeader("Accept", "application/json");

                request.AddHeader("IntegrationID", "1aa6a39b-5f54-4905-880a-a52733fd6105");
                request.AddHeader("Authorization", tokn);
                request.AddHeader("Content-Type", "application/json");


                RestResponse response = await client.PostAsync(request);



                // Check the status code of the response
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Read the response data
                    var responseContent = response.Content.ToString();

                    List<LeaveSumModel> leaveItem = JsonConvert.DeserializeObject<List<LeaveSumModel>>(responseContent);

                    LItems= new ObservableCollection<LeaveSumModel>(leaveItem);
                    SLBal = LItems[0].Bal;
                    Debug.WriteLine("BAL:" + LItems[0].Bal);


                    //Debug.WriteLine(leaveItem[0].LeaveType);
                    //Debug.WriteLine(LItems[0].Taken);

                    return LItems;



                }
                else
                {
                    Debug.WriteLine("Request failed with status code: " + response.StatusCode);
                }
            }
            catch (Exception e)
            {
               Debug.WriteLine(e);
                //Handle not supported on device exception
            }



            return null;

        }
    }
    }
