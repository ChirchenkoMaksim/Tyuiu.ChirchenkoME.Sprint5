using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.ChirchenkoME.Sprint5.Task0.V20.Lib;

namespace Tyuiu.ChirchenkoME.Sprint5.Task0.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 2;

            Console.WriteLine("x = " + x);


            string path = ds.SaveToFileTextData(x);

            Console.WriteLine("File: " + path);
            Console.WriteLine("Слздан!");
            Console.ReadKey();

            Console.ReadKey();

        }
    }
}
