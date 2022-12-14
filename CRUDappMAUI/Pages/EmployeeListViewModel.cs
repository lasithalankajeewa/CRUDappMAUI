using CRUDappMAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDappMAUI.Pages
{
    public class EmployeeListViewModel
    {
        private List<EmployeeModel> _allEmployees = new List<EmployeeModel>();
        public List<EmployeeGroup> Employees { get; set; } = new List<EmployeeGroup>();
        public EmployeeListViewModel()
        {
            _allEmployees.AddRange(new List<EmployeeModel>
            {
                  new EmployeeModel
                {
                    FullName ="Ashwin"
                },
                 new EmployeeModel
                {
                    FullName ="Ashwariya"
                },
                  new EmployeeModel
                {
                    FullName ="Anil"
                },
                new EmployeeModel
                {
                    FullName ="Brijesh"
                },
                 new EmployeeModel
                {
                    FullName ="Biren"
                },
                  new EmployeeModel
                {
                    FullName ="Bhavik"
                },
                   new EmployeeModel
                {
                    FullName ="Carl"
                },
                 new EmployeeModel
                {
                    FullName ="Clay"
                },
                  new EmployeeModel
                {
                    FullName ="Clinton"
                },
                   new EmployeeModel
                {
                    FullName ="Janani"
                },
                 new EmployeeModel
                {
                    FullName ="Jignesh"
                },
                  new EmployeeModel
                {
                    FullName ="Jitesh"
                },
                    new EmployeeModel
                {
                    FullName ="Krishna"
                },
                 new EmployeeModel
                {
                    FullName ="Karishma"
                },
                  new EmployeeModel
                {
                    FullName ="Karan"
                },
                       new EmployeeModel
                {
                    FullName ="Krishna"
                },
                 new EmployeeModel
                {
                    FullName ="Karishma"
                },
                  new EmployeeModel
                {
                    FullName ="Karan"
                },     new EmployeeModel
                {
                    FullName ="Krishna"
                },
                 new EmployeeModel
                {
                    FullName ="Karishma"
                },
                  new EmployeeModel
                {
                    FullName ="Karan"
                },     new EmployeeModel
                {
                    FullName ="Krishna"
                },
                 new EmployeeModel
                {
                    FullName ="Karishma"
                },
                  new EmployeeModel
                {
                    FullName ="Karan"
                },     new EmployeeModel
                {
                    FullName ="Krishna"
                },
                 new EmployeeModel
                {
                    FullName ="Karishma"
                },
                  new EmployeeModel
                {
                    FullName ="Karan"
                },     new EmployeeModel
                {
                    FullName ="Krishna"
                },
                 new EmployeeModel
                {
                    FullName ="Karishma"
                },
                  new EmployeeModel
                {
                    FullName ="Karan"
                },     new EmployeeModel
                {
                    FullName ="Krishna"
                },
                 new EmployeeModel
                {
                    FullName ="Karishma"
                },
                  new EmployeeModel
                {
                    FullName ="Karan"
                },     new EmployeeModel
                {
                    FullName ="Krishna"
                },
                 new EmployeeModel
                {
                    FullName ="Karishma"
                },
                  new EmployeeModel
                {
                    FullName ="Karan"
                },     new EmployeeModel
                {
                    FullName ="Krishna"
                },
                 new EmployeeModel
                {
                    FullName ="Karishma"
                },
                  new EmployeeModel
                {
                    FullName ="Karan"
                },     new EmployeeModel
                {
                    FullName ="Krishna"
                },
                 new EmployeeModel
                {
                    FullName ="Karishma"
                },
                  new EmployeeModel
                {
                    FullName ="Karan"
                },     new EmployeeModel
                {
                    FullName ="Krishna"
                },
                 new EmployeeModel
                {
                    FullName ="Karishma"
                },
                  new EmployeeModel
                {
                    FullName ="Karan"
                },     new EmployeeModel
                {
                    FullName ="Krishna"
                },
                 new EmployeeModel
                {
                    FullName ="Karishma"
                },
                  new EmployeeModel
                {
                    FullName ="Karan"
                },     new EmployeeModel
                {
                    FullName ="Krishna"
                },
                 new EmployeeModel
                {
                    FullName ="Karishma"
                },
                  new EmployeeModel
                {
                    FullName ="Karan"
                }
            });

            var groupedData = _allEmployees.GroupBy(f => f.FullName[0]).Select(f => new EmployeeGroup(f.Key.ToString(), f.ToList()));
            Employees.AddRange(groupedData);
        }

        
    }
}
