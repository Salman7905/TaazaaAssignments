using System;
using ProtectedProgram.Model;
namespace ProtectedProgram
{
    class Program:Vehicle
    {
        static void Main()
        {
            var obj1 = new Program();
            obj1.VehicleType="Heavy Vehicle";
            obj1.VehicleName="Car";
            Console.WriteLine(obj1.VehicleType);
            Console.WriteLine(obj1.VehicleName);
            var obj2 = new Program();
            obj2.VehicleType="Light Vehicle";
            obj2.VehicleName="Bike";
            Console.WriteLine(obj1.VehicleType);
            Console.WriteLine(obj1.VehicleName);
        }
    }
}
