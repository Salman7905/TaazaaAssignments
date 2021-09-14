using System;
namespace ExceptionHandelingP.Customers
{
    // Exeption class in C# is base class in exception handeling ,which can handle all the execeptions
    // AritmeticException is a base class of divide by zero exception, thats why base class can handle derived class exception
    public class Customer
    {
        public void Data(int a ,int b)
        {
             int result = 0;
           try
           { 
           result = a/b; // at this point throw DivideByZeroException // At this point internally "throw" will be called
                                 // when throw will be called , it will find suitable catch 
           }//catch(Exception ex)  // Exception keyword can handeled any type of exception
            catch(ArithmeticException ex)
            {
               Console.WriteLine("Error =>"+ex.GetType());
            }finally
            {
                Console.WriteLine(result);
            }
        }
    }
}