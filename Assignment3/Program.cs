using System;
using Assignment3.Programs;
using Assignment3.Programs1;
namespace Assignment3
{
    class Program:AbstractPro
    {
        static void Main()
        {
          /*   JaggedArray jaggedArray = new JaggedArray();
            jaggedArray.JaggedArr(); */

           // 2D Array

           /* Arr arr = new Arr();
           arr.ArrFun(); */

           // Boxing and Unboxing

           BoxingUnboxing boxingUnboxing = new BoxingUnboxing();
           boxingUnboxing.BoxFun();

           // Interface 
            Drawable d ;
            d = new Rectangle();  
            d.draw();  
            d = new Circle();  
            d.draw(); 

            // Abstract

            var obj=new Sample();
            obj.Abs1("Taazaa");
            obj.NonAbs();         
        
  
        }
    }
}
