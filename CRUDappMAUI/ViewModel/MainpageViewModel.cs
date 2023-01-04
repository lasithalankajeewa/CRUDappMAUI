using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CRUDappMAUI.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CRUDappMAUI.ViewModel
{
    public partial class MainpageViewModel:ObservableObject
    {

        public MainpageViewModel() {
            this.IsRefeshing();
        
        }

        
        public async void IsRefeshing()
        {
            Debug.WriteLine("Refeshing");
            try

            {
                AlraedyApplyLeaveToken Atok=new AlraedyApplyLeaveToken();

                Atok.CompanyId = 156;
                Atok.UserKey = 342922;


                var client = new RestClient();
                var request = new RestRequest("http://10.0.2.2:62185/api/HR/GetAlreadyAppliedLeaves").AddJsonBody(Atok);
                request.Method = Method.Post;
                request.AddHeader("Accept", "application/json");

                request.AddHeader("IntegrationID", "1aa6a39b-5f54-4905-880a-a52733fd6105");
                request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6Ikxhc2l0aGEuQkwiLCJuYW1laWQiOiJMYXNpdGhhLkJMIiwicm9sZSI6IlVzZXIiLCJGaXJzdE5hbWUiOiJMYXNpdGhhLkJMIiwiTGFzdE5hbWUiOiJMYXNpdGhhLkJMIiwiVXNlcklkIjoiTGFzaXRoYS5CTCIsIkVtYWlsIjoiTm8gRW1haWwiLCJDQ0QiOiItLU5PTkNFLS0iLCJuYmYiOjE2NzI2MzI2NDIsImV4cCI6MTY3MjY3NTg0MiwiaWF0IjoxNjcyNjMyNjQyfQ.DoEbpoUIrQvnAFo7aWT-kEoiksS-sXARRzfA3e0dFOc");
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
                Console.WriteLine(e);
                // Handle not supported on device exception
            }

        }

       
    }
}
