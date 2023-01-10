using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CRUDappMAUI.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
//using static Android.Content.ClipData;

namespace CRUDappMAUI.ViewModel
{
    public partial class MainpageViewModel: ObservableObject

    {

        [ObservableProperty]
        ObservableCollection<NewAppliedLeave> _LHItems;

        

        public MainpageViewModel() {
            this.GetAppliedLeave();
        
        }

        public string tokn = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6WyJJc2hhbi5EQyIsIklzaGFuLkRDIl0sIm5hbWVpZCI6IklzaGFuLkRDIiwiRmlyc3ROYW1lIjoiSXNoYW4uREMiLCJVc2VySWQiOiJJc2hhbi5EQyIsIkVtYWlsIjoiTm8gRW1haWwiLCJDQ0QiOiJEQyIsInJvbGUiOiJDb21wYW55QXV0aFN1Y2Nlc3MiLCJuYmYiOjE2NzMzMTgwMzMsImV4cCI6MTY3MzM2MTIzMywiaWF0IjoxNjczMzE4MDMzfQ.8vzOUrIeJzOoMeo1Ezzra4PuCsifxE02Zw7Vw0VRo2U";


        [RelayCommand]
        public async void Refresh()
        { 
            this.GetAppliedLeave();
        }


            public async Task<ObservableCollection<NewAppliedLeave>> GetAppliedLeave()
        {
            try

            {
                Debug.WriteLine("Get Leave History is running");
                AlraedyApplyLeaveToken aalt = new AlraedyApplyLeaveToken();

                aalt.UsrKy = 342922;
                aalt.UsrId = "";
                


                var client = new RestClient("http://bl360x.com/BLEcomTest/api");
                //var client = new RestClient("http://10.0.2.2:62185/api");
                var request = new RestRequest("HR/GetAlreadyAppliedLeaves").AddJsonBody(aalt);
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

                    List<NewAppliedLeave> leaveItem = JsonConvert.DeserializeObject<List<NewAppliedLeave>>(responseContent);

                    LHItems = new ObservableCollection<NewAppliedLeave>(leaveItem);



                    //Debug.WriteLine(leaveItem[0].LeaveType);
                    //Debug.WriteLine(LItems[0].Taken);

                    return LHItems;



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
