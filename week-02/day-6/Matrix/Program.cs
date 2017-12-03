using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[,] matrix=new int[4,4];

            for (int i = 0; i < matrix.GetLength(0); i++)  // sor
            {
                for (int e = 0; e < matrix.GetLength(1); e++) //oszlop
                {                    
                    if(i == e) //sor==oszlop
                    {
                        matrix[i, e] = 1;
                    } else
                    {
                        matrix[i, e] = 0;
                    }

                    Console.Write(matrix[i, e]+" ");
                    
                }

                Console.WriteLine();

            }
                    

            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0      sor==oszlop?1:0
            //   0 1 0 0      
            //   0 0 1 0      
            //   0 0 0 1      
            //
            // - Print this two dimensional array to the output
            Console.ReadLine();
        }
    }
}