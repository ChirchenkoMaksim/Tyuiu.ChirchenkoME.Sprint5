using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.ChirchenkoME.Sprint5.Task3.V15.Lib;

namespace Tyuiu.LavrentevVA.Sprint5.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 5;
            string path = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + path);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
