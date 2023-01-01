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
            Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> _Items;

        [ObservableProperty]
        string pick1;

        [ObservableProperty]
        string pick2;

        [ObservableProperty]
        string pick3;

        [ObservableProperty]
        string text1;

        //[ObservableProperty]
        //string text2;

        [ObservableProperty]
        DateTime date1 = DateTime.Today;

        [ObservableProperty]
        DateTime date2 = DateTime.Today;

        [ObservableProperty]
        TimeSpan nodays;

        [ObservableProperty]
        bool firsthalf;

        [ObservableProperty]
        bool secondhalf;

        [ObservableProperty]
        DateTime time1;

        [ObservableProperty]
        DateTime time2;

        [ObservableProperty]
        TimeSpan leavehours;





        [RelayCommand]
        public async void SubmitClicked()
        {
            Debug.WriteLine(pick1);
            Debug.WriteLine(pick2);
            Debug.WriteLine(pick3);
            Debug.WriteLine(text1);
            Debug.WriteLine(date1);
            Debug.WriteLine(date2);
            Debug.WriteLine(nodays);
            Debug.WriteLine(firsthalf);
            Debug.WriteLine(secondhalf);
            Debug.WriteLine(time1);
            Debug.WriteLine(time2);
            Debug.WriteLine(leavehours);

            TimeSpan datevar = date2 - date1;
            leavehours = time2 - time1;
            Debug.WriteLine("No Hours:" + leavehours);

            Debug.WriteLine("No Days:" + datevar);



            //post request

            var client = new RestClient();
            Token tok = new Token();

            tok.CompanyId = 156;
            tok.UserKey = 342922;
            tok.ObjKy = 1;
            tok.EmpKy = 874258;

            LeaveTypes lt = new LeaveTypes();
            lt.CodeKey = 1;


            LevReason lr = new LevReason();
            lr.CodeKey = 1;

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
            var request = new RestRequest("http://localhost:62185/api/HR/ApplyLeave").AddJsonBody(tok);
            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");

            request.AddHeader("IntegrationID", "1aa6a39b-5f54-4905-880a-a52733fd6105");
            request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6Ikxhc2l0aGEuQkwiLCJuYW1laWQiOiJMYXNpdGhhLkJMIiwicm9sZSI6IlVzZXIiLCJGaXJzdE5hbWUiOiJMYXNpdGhhLkJMIiwiTGFzdE5hbWUiOiJMYXNpdGhhLkJMIiwiVXNlcklkIjoiTGFzaXRoYS5CTCIsIkVtYWlsIjoiTm8gRW1haWwiLCJDQ0QiOiItLU5PTkNFLS0iLCJuYmYiOjE2NzI1Nzg2MDUsImV4cCI6MTY3MjYyMTgwNSwiaWF0IjoxNjcyNTc4NjA1fQ");
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

        //get leave summery 
        public async Task<string> GetLeaveSummery()
        {
            try

            {
                LeaveSummary ls=new LeaveSummary();

                ls.CompanyId = 156;
                ls.UserKey = 28;
                ls.EmpKy = 1;
                ls.Year = "01/01/2022";
              

                var client = new RestClient();
                var request = new RestRequest("http://localhost:62185/api/HR/LoadLeaveSummary").AddJsonBody(ls);
                request.Method = Method.Post;
                request.AddHeader("Accept", "application/json");

                request.AddHeader("IntegrationID", "1aa6a39b-5f54-4905-880a-a52733fd6105");
                request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6Ikxhc2l0aGEuQkwiLCJuYW1laWQiOiJMYXNpdGhhLkJMIiwicm9sZSI6IlVzZXIiLCJGaXJzdE5hbWUiOiJMYXNpdGhhLkJMIiwiTGFzdE5hbWUiOiJMYXNpdGhhLkJMIiwiVXNlcklkIjoiTGFzaXRoYS5CTCIsIkVtYWlsIjoiTm8gRW1haWwiLCJDQ0QiOiItLU5PTkNFLS0iLCJuYmYiOjE2NzI1Nzg2MDUsImV4cCI6MTY3MjYyMTgwNSwiaWF0IjoxNjcyNTc4NjA1fQ");
                request.AddHeader("Content-Type", "application/json");


                RestResponse response = await client.PostAsync(request);



                // Check the status code of the response
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Read the response data
                    var responseContent = response.Content.ToString();

                    Console.WriteLine(responseContent);
                    return responseContent;
                }
                else
                {
                    Console.WriteLine("Request failed with status code: " + response.StatusCode);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Handle not supported on device exception
            }


            return "None";



        }
    }
    }
