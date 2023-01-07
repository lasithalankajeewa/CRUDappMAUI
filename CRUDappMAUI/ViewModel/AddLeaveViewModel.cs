
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
        ObservableCollection<string> _Items;

        [ObservableProperty]
        string _pick1;

        [ObservableProperty]
        int _pick1Index;

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
        int _nodays;

        [ObservableProperty]
        bool _firsthalf;

        [ObservableProperty]
        bool _secondhalf;

        [ObservableProperty]
        DateTime _time1=DateTime.Now;

        [ObservableProperty]
        DateTime _time2=DateTime.Now;

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




        public void OnToggleSwitch( bool IsOn)
        {
            Firsthalf = IsOn;
            Secondhalf = !IsOn;

        }

        public void OnToggleSwitch2(bool IsOn)
        {
            Secondhalf = IsOn;
            Firsthalf = !IsOn;
            

        }

        public void OnPickerChanged()
        {
            if (Pick1Index == 3)
            {

                Time1IsEnabled = true;
                Time2IsEnabled = true;
                LeavehoursIsEnabled = true;

            }
            else {

                Time1IsEnabled = false;
                Time2IsEnabled = false;
                LeavehoursIsEnabled = false;
            }


        }

        public string tokn = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6WyJMYXNpdGhhLkJMIiwiTGFzaXRoYS5CTCJdLCJuYW1laWQiOiJMYXNpdGhhLkJMIiwiRmlyc3ROYW1lIjoiTGFzaXRoYS5CTCIsIlVzZXJJZCI6Ikxhc2l0aGEuQkwiLCJFbWFpbCI6Ik5vIEVtYWlsIiwiQ0NEIjoiREMiLCJyb2xlIjoiQ29tcGFueUF1dGhTdWNjZXNzIiwibmJmIjoxNjczMTE2NzY5LCJleHAiOjE2NzMxNTk5NjksImlhdCI6MTY3MzExNjc2OX0.5N569HAZ04HvIX55KIkdRR7MrC20v7Sfl2VCfxZnFmI";



        [RelayCommand]
        public async void SubmitClicked()
        {
            try
            {

                TimeSpan difference = Date2 - Date1;
                Nodays = difference.Days;
                Debug.WriteLine(_pick1);
                Debug.WriteLine(_pick2);
                Debug.WriteLine(_pick3);
                Debug.WriteLine(_text1);
                Debug.WriteLine(_date1);
                Debug.WriteLine(_date2);
                Debug.WriteLine(Nodays);
                Debug.WriteLine(_firsthalf);
                Debug.WriteLine(_secondhalf);
                Debug.WriteLine(_time1);
                Debug.WriteLine(_time2);
                Debug.WriteLine(_leavehours);
                Debug.WriteLine(_pick1Index);

                //trigger switch
                if (Firsthalf)
                {
                    Firsthalf = !Firsthalf;
                    Secondhalf = false;
                }
                else if (Secondhalf)
                {
                    Firsthalf = false;
                    Secondhalf = !Secondhalf;
                }


                //TimeSpan datevar = _date2 - _date1;
                //leavehours = time2 - time1;
                Debug.WriteLine("Picker1:" + _pick1Index);

                Debug.WriteLine("No Days:" + Nodays);

                


                //post request

                var client = new RestClient();
                Token tok = new Token();

                tok.CompanyId = 156;
                tok.UserKey = 342922;
                tok.ObjKy = 1;
                tok.EmpKy = 874258;

                LeaveTypesParam lt = new LeaveTypesParam();
                lt.CodeKey = 221681;


                LevReasonParam lr = new LevReasonParam();
                lr.CodeKey = 1;
                tok.LevReason = lr;
                tok.LeaveType = lt;
                tok.LeaveTrnKy = 1;
                tok.LeaveTrnTypKy = 221749;
                tok.EftvDt = "01/01/2022";
                tok.ToD = "01/01/2022";
                tok.LevDays = "1";
                tok.IsFirstHalf = false;
                tok.IsSecondHalf = false;
                tok.IsAct = true;
                tok.AcsLvlKy = 1;
                tok.ConFinLvlKy = 1;
                tok.ReporterKy = 727795;
                tok.Rem = "des";
                tok.ReqDate = "01/01/2022";





                //client.Timeout = -1;
                //var request = new RestRequest("http://localhost:62185/api/HR/ApplyLeave").AddJsonBody(tok);
                //var request = new RestRequest("https://bl360x.com/BLECOMTEST/api/HR/ApplyLeave").AddJsonBody(tok);
                //request.Method = Method.Post;
                //request.AddHeader("Accept", "application/json");

                //request.AddHeader("IntegrationID", "1aa6a39b-5f54-4905-880a-a52733fd6105");
                //request.AddHeader("Authorization", tokn);
                //request.AddHeader("Content-Type", "application/json");

                //IsPopUp= true;
                //RestResponse response = await client.PostAsync(request);

                //var client2 = new RestClient("http://bl360x.com/BLEcomTest/api");
                //var client = new RestClient("http://10.0.2.2:62185/api");
                var request2 = new RestRequest("http://bl360x.com/BLEcomTest/api/HR/ApplyLeave").AddJsonBody(tok);
                request2.Method = Method.Post;
                request2.AddHeader("Accept", "application/json");

                request2.AddHeader("IntegrationID", "1aa6a39b-5f54-4905-880a-a52733fd6105");
                request2.AddHeader("Authorization", tokn);
                request2.AddHeader("Content-Type", "application/json");


                RestResponse response2 = await client.PostAsync(request2);


                // check the status code of the response
                if (response2.StatusCode == HttpStatusCode.OK)
                {
                    // read the response data
                    var responsecontent = response2.Content.ToString();

                    Debug.WriteLine("submit succesful!!!");

                    //console.writeline(responsecontent);
                }
                else
                {
                    Debug.WriteLine("request failed with status code: " + response2.StatusCode);
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
