using System;
using System.Collections;
namespace HashTableProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            // inserting element in hashtable
            hash.Add(1,"Lucknow");
            hash.Add(2,"Delhi");
            hash.Add(3,"Noida");
            hash.Add(4,"Chennai");
            hash.Add(5,"Mumbai");
            // delete
            hash.Remove(5);
            // search by key
            Console.WriteLine(hash.ContainsKey(1));  // return true if exists else false
            // search by value
            Console.WriteLine(hash.ContainsValue("Noida"));  // return true if exists else false
            //update
           hash[4]="Banglore";  // will update at key 4
            // Accessing elements
            foreach(DictionaryEntry item in hash)
            {
                System.Console.WriteLine("Key => "+item.Key+" And Value => "+ item.Value);
            }
  
        }
    }
}
