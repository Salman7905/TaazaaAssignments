using System;
namespace Assignment3.Programs
{
    public class BoxingUnboxing
    {
        public void BoxFun()
        {
                    // Boxing
            string name="Taazaa.com";
            object o=name;  // implicitly converts value type into object type and this is called boxing
            Console.WriteLine("After Boxing => "+ o);
             // Unboxing 
             name=(string)o; // explicitly conversion of object type to value type and is called unboxing
             Console.WriteLine("After Unboxing => "+name); 

        }
    }
}