using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChirchenkoME.Sprint5.Task4.V20.Lib
{
    public class DataService : ISprint5Task4V20
    {
        public double LoadFromDataFile(string path)
        {
            //Дан файл С:\DataSprint5\InPutDataFileTask4V0.txt (файл взять из архива согласно вашему варианту. Создать папку в ручную С:\DataSprint5\ и скопировать в неё файл) в котором есть вещественное значение. Прочитать значение из файла и подставить вместо Х в формуле y = (x^2/sin(x))^3 Вычислить значение по формуле (Полученное значение округлить до трёх знаков после запятой) и вернуть полученный результат на консоль.
            string text = File.ReadAllText(path);
            double x = double.Parse(text, CultureInfo.InvariantCulture);
            double y = Math.Pow((Math.Pow(x, 2) / Math.Sin(x)), 3);
            y = Math.Round(y, 3);
            return y;
        }
    }
}
