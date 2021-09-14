using System.Collections.Generic;
using System.Linq;
using ContactRepositoryPractice.Models;
namespace ContactRepositoryPractice.Repository
{
    public class EmployeesRepositiry : IEmployee
    {
        List<Employee> emplopyeelist;
        public EmployeesRepositiry()
        {
            emplopyeelist = new List<Employee>();
        }
        void IEmployee.Add(Employee employee)
        {
           emplopyeelist.Add(employee);
        }

        void IEmployee.Remove(int id)
        {
            var employeeToRemove = emplopyeelist.Where(e=>e.EmployeeID==id).SingleOrDefault();
            if(employeeToRemove!=null)
            {
                emplopyeelist.Remove(employeeToRemove);
            }
        }
        void IEmployee.Update(Employee employee)
        {
            var employeeToUpdate = emplopyeelist.Where(e=>e.EmployeeID==employee.EmployeeID).SingleOrDefault();
            if(employeeToUpdate!=null)
            {
                employeeToUpdate.EmployeeID = employee.EmployeeID;
                employeeToUpdate.EmployeeName = employee.EmployeeName;
            }
        }
        Employee IEmployee.Find(int id)
        {
            var employee = emplopyeelist.Where(e=>e.EmployeeID==id).SingleOrDefault();
            return employee;
            
        }
        List<Employee> IEmployee.GetAll()
        {
            return emplopyeelist;
        }
    }
}