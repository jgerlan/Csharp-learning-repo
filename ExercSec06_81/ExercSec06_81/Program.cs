using System;

namespace ExercSec06_81
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimensionsString = Console.ReadLine().Split(' ');
            int[] dimensions = new int[] { int.Parse(dimensionsString[0]), int.Parse(dimensionsString[1]) };
            int[,] mat = new int[dimensions[0], dimensions[1]];
            int findNumber = 0;

            for (int row=0; row<dimensions[0];row++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int column = 0; column<dimensions[1]; column++)
                {
                    mat[row, column] = int.Parse(values[column]);
                }
            }

            findNumber = int.Parse(Console.ReadLine());

            for (int row = 0; row < dimensions[0]; row++)
            {
                for (int column = 0; column < dimensions[1]; column++)
                {
                    if(findNumber == mat[row, column])
                    {
                        Console.WriteLine($"Position: {row},{column}");
                        if ( column > 0 ) { Console.WriteLine("Left: " + mat[row, column - 1]); }
                        if ( column < dimensions[1]-1) { Console.WriteLine("Right: " + mat[row, column + 1]); }
                        if (row > 0) { Console.WriteLine("Up: " + mat[row - 1, column]); }
                        if (row < dimensions[0]-1) { Console.WriteLine("Down: " + mat[row + 1, column]); }
                        
                        
                        
                    }
                }
                Console.WriteLine();
            }

            /*for (int row = 0; row < dimensions[0]; row++)
            {
                for (int column = 0; column < dimensions[1]; column++)
                {
                    Console.Write(mat[row, column]+" ");
                }
                Console.WriteLine();
            }*/

        }
    }
}
