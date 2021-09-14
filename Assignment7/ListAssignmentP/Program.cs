using System;
using ListAssignmentP.OOPsContact;
namespace ListAssignmentPs
{
    class Program
    {
        static void Main()
        {
            var obj = new ContactList();
            var list = obj.AddContact();
            obj.searchContact();
            //obj.deleteContact();
            obj.updateContact();
             foreach(var i in list)
            {
                Console.WriteLine(i.Eid+" "+i.cName+" "+i.cMail);
            } 
        }
    }
}
