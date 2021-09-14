using ListPractice.EmployeesList;
using ListPractice.Employees;
using System.Collections.Generic;

namespace ListPractice.Employees
{
    interface IEmployee
    {
        void addEmployee(Employee emp);
        List<Employee> employeeDisplay();
        Employee searchEmployee(int eid);
        
    }
}