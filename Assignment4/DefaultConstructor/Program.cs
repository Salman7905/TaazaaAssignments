using System;

namespace DefaultConstructor
{
    class PConstructor
    {
        public static int EmpID;
        public static string EmpName;
        // private constructor
        private PConstructor()
        {
            Console.WriteLine("Private Constructor");
        }
        public PConstructor(int id,string name)
        {
            EmpID=id;
            EmpName=name;
        }
        static void Main(string[] args)
        {
           // This line raises error because the constructor is inaccessible
           // var obj=new PConstructor(); 

          // Here, the only default constructor will invoke
          var obj = new PConstructor(101,"ABD");
          Console.WriteLine("Employee ID => "+PConstructor.EmpID+" \n Employee Name => "+PConstructor.EmpName);
            
        }
    }
}
