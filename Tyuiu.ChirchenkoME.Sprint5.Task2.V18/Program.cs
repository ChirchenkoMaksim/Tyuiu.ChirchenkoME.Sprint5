using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.ChirchenkoME.Sprint5.Task2.V18.Lib;


namespace Tyuiu.LavrentevVA.Sprint5.Task2.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int [,] matrix = new int[3, 3];

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            string path = ds.SaveToFileTextData(matrix);
            Console.WriteLine("File: " + path);
            Console.WriteLine("Created!");


            Console.ReadKey();
        }
    }
}
