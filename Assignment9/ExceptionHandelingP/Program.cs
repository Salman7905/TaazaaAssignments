using System;
using  ExceptionHandelingP.Customers;
namespace ExceptionHandelingP
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Data(80,0);     
        }
    }
}
