using System;
namespace Assignment3.Programs
{
    public class JaggedArray
    {
            public void JaggedArr()
            {
             int[][] Jarray=new int[2][]; // it is manadatory to define the size of first array
             Jarray[0]=new int[2];
             Jarray[1]=new int[3];
             Jarray[0][0]=10;
             Jarray[0][1]=20;
             Jarray[1][0]=30;
             Jarray[1][1]=40;
             Jarray[1][2]=50;
             Console.WriteLine("Jagged Array elementa are : ");
             for(int i=0;i<Jarray.GetLength(0);i++)
             {
               for(int j=0;j<Jarray[i].GetLength(0);j++){
                   Console.Write(Jarray[i][j]+" ");
               }
                Console.WriteLine("\n");
             }
        }
    }
}