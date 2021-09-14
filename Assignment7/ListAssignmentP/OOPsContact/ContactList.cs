using ListAssignmentP.PropertyContact;
using System.Collections.Generic;
using System;
namespace ListAssignmentP.OOPsContact
{
    public class ContactList
    {
        List<Contact> list;
        public ContactList()
        {
            list = new List<Contact>();
        }
        public List<Contact> AddContact()
        {
            list.Add(new Contact{
                Eid=101,
                cName="Robert",
                cMail="rbt@gmail.com"
            });
            list.Add(new Contact{
                Eid=102,
                cName="Jhon",
                cMail="jn@gmail.com"
            });
            list.Add(new Contact{
                Eid=103,
                cName="Chris",
                cMail="ch@gmail.com"
            });
            list.Add(new Contact{
                Eid=104,
                cName="sam",
                cMail="sm@gmail.com"
            });
            return list;
        }
        public void updateContact()
        {
            int target = 2;
            list[target].cName="Mike";
            list[target].cMail="mk@gmail.com";
            Console.WriteLine("Record Updated!");
        }
        public void deleteContact()
        {
            int target =3;
            list.RemoveAt(target);
            Console.WriteLine("Record Deleted!");
        }
        public void searchContact()
        {
                 int target = 1;
                list.FindIndex(employee =>employee.Eid ==target);
                Console.WriteLine("Found");
                Console.WriteLine("Name => "+list[target].cName+"\nEmail => "+list[target].cMail);
        }
    }
}