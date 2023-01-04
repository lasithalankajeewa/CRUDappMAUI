
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CRUDappMAUI.Models;
using Microsoft.Maui.Devices.Sensors;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace CRUDappMAUI.ViewModel
{
    public partial class AddLeaveViewModel : ObservableObject
    {
        public AddLeaveViewModel()
        {
            //Items = new ObservableCollection<string>();
            this.GetLeaveSummery();
           // this.ToggleSwitch();

          //  Thread thread = new Thread(ToggleSwitch);
           // thread.Start();
            
        }

        [ObservableProperty]
        ObservableCollection<string> _Items;

        [ObservableProperty]
        string _pick1;

        [ObservableProperty]
        string _pick2;

        [ObservableProperty]
        string _pick3;

        [ObservableProperty]
        string _text1;

        //[ObservableProperty]
        //string text2;

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
        DateTime _time1;

        [ObservableProperty]
        DateTime _time2;

        [ObservableProperty]
        TimeSpan _leavehours;


   

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
                Debug.WriteLine("No Hours:" + _leavehours);

                Debug.WriteLine("No Days:" + Nodays);

                


                //post request

                var client = new RestClient();
                Token tok = new Token();

                tok.CompanyId = 156;
                tok.UserKey = 342922;
                tok.ObjKy = 1;
                tok.EmpKy = 874258;

                LeaveTypesParam lt = new LeaveTypesParam();
                lt.CodeKey = 1;


                LevReasonParam lr = new LevReasonParam();
                lr.CodeKey = 1;
                tok.LevReason = lr;
                tok.LeaveType = lt;
                tok.LeaveTrnKy = 1;
                tok.LeaveTrnTypKy = 1;
                tok.EftvDt = "01/01/2022";
                tok.ToD = "03/01/2022";
                tok.LevDays = "3";
                tok.IsFirstHalf = false;
                tok.IsSecondHalf = false;
                tok.IsAct = false;
                tok.AcsLvlKy = 1;
                tok.ConFinLvlKy = 1;
                tok.ReporterKy = 1;
                tok.Rem = "test";
                tok.ReqDate = "04/01/2022";





                //client.Timeout = -1;
                //var request = new RestRequest("http://localhost:62185/api/HR/ApplyLeave").AddJsonBody(tok);
                var request = new RestRequest("https://bl360x.com/BLECOMTEST/api/HR/ApplyLeave").AddJsonBody(tok);
                request.Method = Method.Post;
                request.AddHeader("Accept", "application/json");

                request.AddHeader("IntegrationID", "1aa6a39b-5f54-4905-880a-a52733fd6105");
                request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6WyJMYXNpdGhhLkJMIiwiTGFzaXRoYS5CTCJdLCJuYW1laWQiOiJMYXNpdGhhLkJMIiwiRmlyc3ROYW1lIjoiTGFzaXRoYS5CTCIsIlVzZXJJZCI6Ikxhc2l0aGEuQkwiLCJFbWFpbCI6Ik5vIEVtYWlsIiwiQ0NEIjoiREMiLCJyb2xlIjoiQ29tcGFueUF1dGhTdWNjZXNzIiwibmJmIjoxNjcyODI3MjczLCJleHAiOjE2NzI4NzA0NzMsImlhdCI6MTY3MjgyNzI3M30.vZ6w7hz79lRvnkFgM8XfrlrcHkhGM6NpOx10Uqz72Lc");
                request.AddHeader("Content-Type", "application/json");


                RestResponse response = await client.PostAsync(request);



                // Check the status code of the response
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Read the response data
                    var responseContent = response.Content.ToString();

                    Console.WriteLine(responseContent);
                }
                else
                {
                    Console.WriteLine("Request failed with status code: " + response.StatusCode);
                }



            }
            catch (Exception ex) { 
            
                Debug.WriteLine(ex.ToString());
            
            }
            

        }

        //get leave summery 
        public async Task<string> GetLeaveSummery()
        {
            try

            {
                Debug.WriteLine("Leave Summery is running");
                LeaveSummary ls=new LeaveSummary();

                //ls.CompanyId = 156;
                ls.UserKey = 342922;
                ls.EmpKy = 874258;
                ls.Year = "2022/01/01";


                var client = new RestClient("http://bl360x.com/BLEcomTest/api/HR/LoadLeaveSummary");
                //var client = new RestClient("http://10.0.2.2:62185/api");
                var request = new RestRequest("/HR/LoadLeaveSummary").AddJsonBody(ls);
                request.Method = Method.Post;
                request.AddHeader("Accept", "application/json");

                request.AddHeader("IntegrationID", "1aa6a39b-5f54-4905-880a-a52733fd6105");
                request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6WyJMYXNpdGhhLkJMIiwiTGFzaXRoYS5CTCJdLCJuYW1laWQiOiJMYXNpdGhhLkJMIiwiRmlyc3ROYW1lIjoiTGFzaXRoYS5CTCIsIlVzZXJJZCI6Ikxhc2l0aGEuQkwiLCJFbWFpbCI6Ik5vIEVtYWlsIiwiQ0NEIjoiREMiLCJyb2xlIjoiQ29tcGFueUF1dGhTdWNjZXNzIiwibmJmIjoxNjcyODI3MjczLCJleHAiOjE2NzI4NzA0NzMsImlhdCI6MTY3MjgyNzI3M30.vZ6w7hz79lRvnkFgM8XfrlrcHkhGM6NpOx10Uqz72Lc");
                request.AddHeader("Content-Type", "application/json");


                RestResponse response = await client.PostAsync(request);



                // Check the status code of the response
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Read the response data
                    var responseContent = response.Content.ToString();

                    Console.WriteLine(responseContent);
                    Debug.WriteLine(responseContent);
                    

                }
                else
                {
                    Debug.WriteLine("Request failed with status code: " + response.StatusCode);
                }
            }
            catch (Exception e)
            {
               Debug.WriteLine(e);
                // Handle not supported on device exception
            }


            return "None";



        }
    }
    }
