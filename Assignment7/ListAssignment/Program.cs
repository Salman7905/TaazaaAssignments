using System;
using System.Collections.Generic;
using ListAssignment.Model;
namespace ListAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
         List<Contacts> list = new List<Contacts>();
         list.Add(new Contacts{
           cId=101,
           cName="Mike",
           cMail="hi@gmail.com"
         });
         list.Add(new Contacts{
             cId=102,
             cName="Chris",
             cMail="hello@gmail.com"
         });

            list.Add(new Contacts{
             cId=103,
             cName="Sam",
             cMail="by@gmail.com"
         });
         
         // updating
         int tgt =3;
         list[tgt].cName="Robert";
         list[tgt].cMail="rbt@gmail.com";
         Console.WriteLine("Updated Record "+list[tgt].cName +" "+list[tgt].cMail);
         
         //Deleting record
         int t=1;
         list[t].Remove(new Contacts{
             list.c
         });
         // Showing all records
         /* int count = list.Count;
         for(int i=0;i<count;i++)
         {
             Console.WriteLine("ID => "+list[i].cId+"\nName =>"+list[i].cName+"\nMail => "+list[i].cMail);
             Console.WriteLine("----------");
         } */
         }
    }
}
