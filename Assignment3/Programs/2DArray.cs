using System;
namespace Assignment3.Programs1
{
    public class Arr
    {
        public void ArrFun()
        {
            // 2D array
            int[,] arr = { { 1, 2, 3 },
                              { 4, 5, 6 }, 
                              { 7, 8, 9 } };  //declaration and initialization  
  	
            //traversal  
            for(int i=0;i<3;i++)
            {  
                for(int j=0;j<3;j++) 
                {  
                    Console.Write(arr[i,j]+" ");  
                }  
                Console.WriteLine();
    
            }

        }
    }
}