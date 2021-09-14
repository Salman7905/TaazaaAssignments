using System;
using AdvanceDeligate.Model; 
delegate void Cal(double x,double y);
namespace AdvanceDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TypeOfOperation obj;
            Console.WriteLine("\n _______Calculator_______ \n Enter first Number :- ");
            double a=Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("\n Enter the second number :- ");
            double b=Convert.ToDouble(Console.ReadLine());
            
            obj=new TypeOfOperation(a,b);

            int ch =0;
            Console.WriteLine("1) Delegate Type \n2) Anonymous Type \n3) Lamda Function Type  \n4) Exit to main menu ");
            while(ch!=4)
            {  
                Console.WriteLine("Enter your Choice :-");
                ch=Convert.ToInt32(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        obj.delegateType();
                        break;
                    case 2:
                        obj.anonymousType();
                        break;
                    case 3:
                        obj.lamdaType();
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            } 
        }
      }
    }
