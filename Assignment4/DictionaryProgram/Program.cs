using System;
using System.Collections.Generic;
namespace DictionaryProgram
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Dictionary<int,string> Dic_Name = new Dictionary<int, string>();
            Dic_Name.Add(101,"Sam");
            Dic_Name.Add(102,"Smith");
            Dic_Name.Add(103,"Robert");
            Dic_Name.Add(104,"Chris");
            Dic_Name.Add(105,"Mike");
            // Dic_Name.Clear()       // it will remove all elements from dictionary

            Dic_Name.Remove(105);   // key 105 will remove

            Dic_Name[101]="DeVilliers";  // Update the value at 101 kay

            Console.WriteLine(Dic_Name.ContainsValue("DeVilliers")); // to search the value , if exists will return true

            //Accessing elements
            
            foreach(KeyValuePair<int,string> items in Dic_Name)
            {
                Console.WriteLine("Employee ID => "+items.Key+" | Employee Name => "+items.Value);
            }
        }
    }
}
