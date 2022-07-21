using System;

namespace Nested_For_Loops_And_2D_Arrays
{
    internal class Program
    {
        static int[,] matrix =
        {
            {1,2,3 },
            {4,5,6 },
            {7,8,9 }
        };

        static void Main(string[] args)
        {
            // 1. way: FOREACH LOOP: I'M GONNA ITERATE / RUN THROUGH "MATRIX" ARRAY
            
            /*
            foreach (int item in matrix)
            {
                Console.Write(item + " ");
            }

            */
            
            // 2. way: NESTED FOR LOOP

            Console.WriteLine("This is our 2D array printed using a Nested For Loop ");
            // outer for loop inside a Nested For Loop
            for (int i = 0; i < matrix.GetLength(0); i++) // (0) = the number of ROWS
            {
                // inner for loop inside a Nested For Loop
                // j < matrix.GetLength(1) => "j" will iterate/run as long as its number is lower than 
                //                            the number of columns (matrix.GetLength(1)) which is =3. 
                //                            And then it will go back to the outer For Loop which will 
                //                            iterate through the next row and its 3 columns and so forth
                for (int j = 0; j < matrix.GetLength(1); j++) // (1) - the number of COLUMNS
                {
                    Console.Write(matrix[i,j] + " ");
                }
            }

        }

    }
}
