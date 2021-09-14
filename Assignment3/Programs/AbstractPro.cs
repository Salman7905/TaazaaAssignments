using System;
namespace Assignment3.Programs
{
    public class AbstractPro
    {
        // Abstract class
    public abstract class Example
    {
        // Abstract method
        public abstract void Abs1(string n);
        public  void NonAbs()
        {
            Console.WriteLine(" Non Abs Method");
        }
    }
    
    public class Sample:Example
    {
        public override void Abs1(string s)
        {
            Console.WriteLine("Overriding Abstract method " +s);
        }
    }

    }
}