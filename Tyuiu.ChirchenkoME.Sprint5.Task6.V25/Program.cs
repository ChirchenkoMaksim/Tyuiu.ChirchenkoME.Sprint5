using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.ChirchenkoME.Sprint5.Task6.V25.Lib;


namespace Tyuiu.LavrentevVA.Sprint5.Task6.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask6V25.txt";
            int result = ds.LoadFromDataFile(path);
            Console.WriteLine("Результат: " + result);

            Console.ReadKey();
        }
    }
}

