using System.ComponentModel.DataAnnotations;

namespace ContactRepositoryPractice.Models
{
    public class Employee
    {
        public int EmployeeID{get;set;}
        public string EmployeeName{get;set;}
        [Range(20,60)]
        public int EmployeeAge{get;set;}
        public int EmployeeSalary{get;set;}
        
    }
}