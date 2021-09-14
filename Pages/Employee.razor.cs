using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using lat_blazor.Models;

namespace lat_blazor.Pages 
{
    public partial class EmployeePage 
    {
        public IEnumerable <Employee> Employees { get; set; }
        
        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees(){
            Employee e1 = new Employee{
                EmployeeId=1,
                FirstName="Rosalia",
                LastName="Natasha",
                Email="ronatasha11@gmail.com",
                DateOfBirth = new DateTime(2002,01,11),
                Gender = Gender.Female,
                Department = new Department{DepartmentId=1,DepartmentName="IT"},
                PhotoPath = "images/rosa.jpg"
            };

             Employee e2 = new Employee{
                EmployeeId=2,
                FirstName="Haniel",
                LastName="Obed",
                Email="hanielobed@gmail.com",
                DateOfBirth = new DateTime(2000,12,4),
                Gender = Gender.Male,
                Department = new Department{DepartmentId=2,DepartmentName="IT"},
                PhotoPath = "images/obed.jpg"
                  };
                  
             Employee e3 = new Employee{
                EmployeeId=3,
                FirstName="Meylisa",
                LastName="Putri",
                Email="meylisaishariyanti@gmail.com",
                DateOfBirth = new DateTime(1999,07,06),
                Gender = Gender.Female,
                Department = new Department{DepartmentId=2,DepartmentName="IT"},
                PhotoPath = "images/mey.jpg"
                   };

                   Employees = new List<Employee>{e1,e2,e3};
        }
    }
}