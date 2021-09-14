using System;
using System.IO;
namespace FileHandelingP.FileHandeling
{
    public class FileHandler
    {
        public void writeToFile(string s)
        {
            FileStream fileStream= new FileStream("Training.txt",FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.Write(s);
            Console.WriteLine("Data inserted in file successfully");
            streamWriter.Close();
            fileStream.Close();
        }
        public void readFromFile()
        {
          FileStream fileStream = new FileStream("Training.txt",FileMode.Open);
          StreamReader streamReader = new StreamReader(fileStream);
          string fileData = streamReader.ReadLine();
          Console.WriteLine(fileData);
          streamReader.Close();
          fileStream.Close();          
        }
    }
}