using System;

namespace ForeachLoopPro
{
    class Program
    {
        static void Main(string[] args)
        {      
        string[] list = new string[] { "hi", "DeVilliers", "Mike", "Sam","Jhon" }; 
        foreach(string items in list) 

        { 
            Console.WriteLine(items); 
        } 
        }
    }
}
