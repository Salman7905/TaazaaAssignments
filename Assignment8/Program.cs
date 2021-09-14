using System;

namespace SwitchCasePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch = 0;
            while(ch!=4)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("1.) Add Employee\n2.) Update Employee\n3.) Delete Employee\n4.) Exit");
                Console.WriteLine("Please enter your choice :)");
                ch = Convert.ToInt32(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                           Console.WriteLine("Employee added successfully...");
                           break;
                    case 2: 
                           Console.WriteLine("Employee deatils updated successfully...");
                           break;
                    case 3:
                          Console.WriteLine("Employee deleted successfully...");
                          break;
                    case 4:
                          Console.WriteLine("Exit successfully");
                          break;
                    default:
                          Console.WriteLine("Invalid choice!");
                          break;
                }
            }
        }
    }
}
