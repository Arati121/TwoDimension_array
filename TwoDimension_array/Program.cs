using System;

namespace TwoDimension_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] list = new int[3, 6] { { 1, 2, 3, 4, 5, 6 }, { 7, 8, 9, 10, 11, 12 }, { 13, 14, 15, 16, 17, 18 } };
           for(int i=0;i<3;i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(list[i, j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("____________HardCOde value______________");
            int[,] data = new int[3, 4];
            for(int i=0;i<data.GetLength(0);i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write(data[i,j]+" ");
                }
                Console.WriteLine();
            }
               


            
            
     

        }
    }
}
