using System;
using FileHandelingP.FileHandeling;
namespace FileHandelingP
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandler fileHandler = new FileHandler();
           // fileHandler.writeToFile("I am Salman Ahmed and doing training for betterment");
            fileHandler.readFromFile();
        }   
    }
}
