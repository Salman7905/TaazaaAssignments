using System;
using ListPractice.EmployeesList;
using ListPractice.Employees;
using System.Collections.Generic;
namespace ListPractice
{
    class Program
    {
        static void Main()
        {
            Employee emp1 = new Employee();
            emp1.Eid=101;
            emp1.Ename="Mike";
           
            Employee emp2 = new Employee();
            emp2.Eid=102;
            emp2.Ename="Robert";

            EmployeeList employeeList = new EmployeeList();
            employeeList.addEmployee(emp1);
            employeeList.addEmployee(emp2);

            List<Employee> list = employeeList.employeeDisplay();

            employeeList.updateEmployee(emp2);
            foreach(var item in list)
            {
                Console.WriteLine(item.Eid+" "+item.Ename);
            }
            Employee empSearch = employeeList.searchEmployee(104);
            if(empSearch==null)
            {
              Console.WriteLine("Record Not found!");
            }else
            {
                Console.WriteLine("Found "+empSearch.Ename);
            }
        }
    }
}
