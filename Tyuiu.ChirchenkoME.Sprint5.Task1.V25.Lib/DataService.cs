using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChirchenkoME.Sprint5.Task1.V25.Lib
{
    public class DataService : ISprint5Task1V25
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            // Дана функция: F(x) = (2sin(x)/3x+1.2) + cos(x) - 7x * 2 Произвести табулирование функции f(x) на заданном диапазоне[-5; 5] с шагом 1. Произвести проверку деления на ноль.При делении на ноль вернуть значение 0. Результат сохранить в текстовый файл OutPutFileTask1.txt и вывести на консоль в таблицу. Значения округлить до двух знаков после запятой.
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;

            if (exists)
            {
                file.Delete();
            }

            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 2.5 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = (2 * Math.Sin(x) / (3 * x + 1.2)) + Math.Cos(x) - 7 * x * 2;
                }
                y = Math.Round(y, 2);
                strY = Convert.ToString(y);
                File.AppendAllText(path, strY + "\n");

            }
            return path;




        }
    }
}
