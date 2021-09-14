using System;
using DelegateP.AdvanceDelegate;
 // delegate void PhoneNDel();
//delegate bool StudyStatusDel();
namespace DelegateP
{
    class Program
    {
        static void Main()
        {
         Study study = new Study();
        // NameDel nameDel = new NameDel(study.Name); 
        // string name = nameDel.Invoke("Salman Ahmed");
        // Console.WriteLine(name);
           Func<string ,string > func = study.Name;
           string fname = func("Mike");
           Console.WriteLine(fname);      
              
        // return type void then action
          Action action = study.PhoneNo;
          action();

        // for return type bool
        Predicate<string> predicate = study.StudyStatus;
        bool status = predicate("Hello");
        Console.WriteLine(status);
        }
    }
}
