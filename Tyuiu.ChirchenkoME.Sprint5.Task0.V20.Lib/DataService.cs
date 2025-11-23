using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChirchenkoME.Sprint5.Task0.V20.Lib
{
    public class DataService : ISprint5Task0V20
    {
        public string SaveToFileTextData(int x)
        {
            // Дано выражение f(x) = 2.12x^3 + 1.05x^2 + 4.1x * 2 вычислить его значение при x = 2, результат сохранить в текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до трёх знаков после запятой.
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double result = 2.12 * Math.Pow(x, 3) + 1.05 * Math.Pow(x, 2) + 4.1 * x * 2;
            result = Math.Round(result, 3);
            File.WriteAllText(path, result.ToString());
            return path;
        }
    }
}
