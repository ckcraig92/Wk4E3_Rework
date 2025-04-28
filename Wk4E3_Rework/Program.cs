using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4E3_Rework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                //Declarations creating the matrix
                int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

                Console.WriteLine("Original matrix: ");//print for user to view
                for (int i = 0; i < matrix.GetLength(0); i++) //loop through rows
                {
                    for (int j = 0; j < matrix.GetLength(1); j++) //loop through columns
                    {
                        Console.Write(matrix[i, j] + "\t"); //tab space
                    }
                    Console.WriteLine(); //next line
                }
                //calculate
                int sum = 0;

                foreach (int i in matrix) //loop 
                {
                    sum += i; //add to the sum

                }

                Console.WriteLine("Sum of the elements in the matrix: " + sum); //print for user to view

                //transpose
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                //Create a transposed matrix (2x3)
                int[,] transposed = new int[cols, rows];

                //swap rows & columns
                Console.WriteLine("Transposed matrix: "); //for user to view
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        transposed[j, i] = matrix[i, j]; //swap row & column
                    }
                }

                for (int i = 0; i < transposed.GetLength(0); i++) //loop through rows
                {
                    for (int j = 0; j < transposed.GetLength(1); j++) //loop through columns
                    {
                        Console.Write(transposed[i, j] + "\t"); //tab spacing
                    }
                    Console.WriteLine(); //next line
                }

                
            }
        }
    }
}
 