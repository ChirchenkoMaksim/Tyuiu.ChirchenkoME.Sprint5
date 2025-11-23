using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.ChirchenkoME.Sprint5.Task5.V21.Lib;

namespace Tyuiu.LavrentevVA.Sprint5.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask5V21.txt";
            double result = ds.LoadFromDataFile(path);
            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}
