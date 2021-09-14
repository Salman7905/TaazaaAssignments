using System;
using System.Collections.Generic;
namespace SwitchCaseProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> Dic = new Dictionary<int, string>();
            int ch=0;
            while(ch>=0 && ch<6)
            {
              Console.WriteLine("----------------------");
              Console.WriteLine(" 1.) Add Employee\n 2.) Update\n 3.) Search\n 4.) Show\n 5.) Delete\n 6.) Exit");
               ch = Convert.ToInt32(Console.ReadLine());
              switch(ch)
              {
                  case 1:
                          Console.WriteLine("Please enter Employee ID and Employee name");
                          int Eid = Convert.ToInt32(Console.ReadLine());
                          string Ename = Console.ReadLine();
                          Dic.Add(Eid,Ename);
                          Console.WriteLine("New Employee Added!");
                          break;
                 case 2:
                          Console.WriteLine("Please enter Employee ID to update");
                           Eid = Convert.ToInt32(Console.ReadLine());
                           if(Dic.ContainsKey(Eid))
                           {
                            Console.WriteLine("Please enter Employee name to update");
                            Ename = Console.ReadLine();
                            Dic[Eid]=Ename;
                            Console.WriteLine("Employee Details Updated!");
                            break;
                           }
                           else
                           {
                             Console.WriteLine("Employee Does not exists");
                             break;
                           }
                  case 3:
                          Console.WriteLine("Please enter Employee ID to Search");
                           Eid = Convert.ToInt32(Console.ReadLine());
                           if(Dic.ContainsKey(Eid))
                           {
                            Console.WriteLine("Employee Found!");
                            break;
                           }
                           else
                           {
                             Console.WriteLine("Employee Does not exists");
                             break;
                           }
                   case 4:        
                           Console.WriteLine("Please enter Employee ID to Show Details");
                           Eid = Convert.ToInt32(Console.ReadLine());
                           if(Dic.ContainsKey(Eid))
                           {
                            Console.WriteLine("Employee ID => "+Eid+"\nEmployee Name => "+Dic[Eid]);
                            break;
                           }
                           else
                           {
                             Console.WriteLine("Employee Does not exists");
                             break;
                           } 
                    case 5:
                           Console.WriteLine("Please enter Employee ID to Delete");
                           Eid = Convert.ToInt32(Console.ReadLine());
                           if(Dic.ContainsKey(Eid))
                           {
                            Dic.Remove(Eid);
                            Console.WriteLine("Employee Deleted!");
                            break;
                           }
                           else
                           {
                             Console.WriteLine("Employee Does not exists");
                             break;
                           }  
              }
            }
        }
    }
}
