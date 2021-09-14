using System;

namespace PropertiesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Laptop();
            obj.Brand="Lenovo";
            obj.Model="Ideapad320";
            Console.WriteLine("Brand => "+obj.Brand);
            Console.WriteLine("Model => "+obj.Model);
            var obj1 = new Laptop();
            obj1.Brand="Dell";
            obj1.Model="Inspiron 14R";
            Console.WriteLine("Brand => "+obj1.Brand);
            Console.WriteLine("Model => "+obj1.Model);
        }
    }
}
