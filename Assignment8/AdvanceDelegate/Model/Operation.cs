using System;
using Arithmetics;
delegate void option(double a,double b);

namespace AdvanceDeligate.Model
{
    public class TypeOfOperation
    { 
        double x,y;
        public TypeOfOperation(double a,double b)
        {
        x=a;y=b;
        }
        public void delegateType()
        {
            var dobj=new option(Airthmetic.addition);
            Console.WriteLine("\n ___All Operations are Done using Delegate____ \n");
            dobj+=Airthmetic.subtraction;
            dobj+=Airthmetic.multiplication;
            dobj+=Airthmetic.division;
            dobj.Invoke(x,y);
        }
        public  void anonymousType()
        {
            Console.WriteLine("\n ___All Operations are Done using Anonymous Method ____ \n");
            option add=delegate(double no1,double no2)
            {
                Console.WriteLine("Addition of "+no1 +" and "+no2+" = "+(no1+no2));
            };
            option sub=delegate(double no1,double no2)
            {
                Console.WriteLine("Substraction of "+no1 +" and "+no2+" = "+(no1-no2));
            };
            option mul=delegate(double no1,double no2)
            {
                Console.WriteLine("Multiplication of "+no1 +" and "+no2+" = "+(no1*no2));
            };
            option div=delegate(double no1,double no2)
            {
                Console.WriteLine("Division of "+no1 +" and "+no2+" = "+(no1/no2));
            };
            add(x,y);
            sub(x,y);
            mul(x,y);
            div(x,y);
        }
        public void lamdaType()
        {
        Console.WriteLine("\n ___All Operations are Done using Lamda Function ____ \n");
            option add=(double no1,double no2)=>
            {
                Console.WriteLine("Addition of "+no1 +" and "+no2+" = "+(no1+no2));
            };
            option sub=(double no1,double no2)=>
            {
                Console.WriteLine("Substraction of "+no1 +" and "+no2+" = "+(no1-no2));
            };
            option mul=(double no1,double no2)=>
            {
                Console.WriteLine("Multiplication of "+no1 +" and "+no2+" = "+(no1*no2));
            };
            option div=(double no1,double no2)=>
            {
                Console.WriteLine("Division of "+no1 +" and "+no2+" = "+(no1/no2));
            };
            add(x,y);
            sub(x,y);
            mul(x,y);
            div(x,y);
        }
    }
}