using System;
using ListPractice.Employees;
using System.Collections.Generic;
namespace ListPractice.EmployeesList
{
    public class EmployeeList
    {
       List<Employee> employees;
       public EmployeeList()
       {
           employees = new List<Employee>();
       } 
       public void addEmployee(Employee emp)
       {
           employees.Add(emp);
       }
       public List<Employee> employeeDisplay()
       {
           return employees;
       }
       public Employee searchEmployee(int eid)
       {
           return employees.Find(e=>e.Eid==eid);
       }
       public void updateEmployee(Employee emp)
       {
            emp.Ename="DeVillers";
            Console.WriteLine("Updated Successfully");
       }
       public void deleteEmployee(Employee emp)
       {
           employees.Remove(emp);
           Console.WriteLine("Record deleted successfully...");
       }
    }
}