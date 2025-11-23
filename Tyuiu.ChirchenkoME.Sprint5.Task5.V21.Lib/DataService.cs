using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChirchenkoME.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            //Дан файл С:\DataSprint5\InPutDataFileTask5V21.txt (файл взять из архива согласно вашему варианту.  Создать папку в ручную С:\DataSprint5\ и скопировать в неё файл) в котором есть набор значений. Найти факториал наибольшего целого числа, которое делится на 2, в файле. Полученный результат вывести на консоль. У вещественных значений округлить до трёх знаков после запятой.
            string content = File.ReadAllText(path);
            string[] values = content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int maxEvenInt = int.MinValue;
            foreach (string value in values)
            {
                if (int.TryParse(value, out int intValue))
                {
                    if (intValue % 2 == 0 && intValue > maxEvenInt)
                    {
                        maxEvenInt = intValue;
                    }
                }
            }
            if (maxEvenInt == int.MinValue)
            {
                throw new InvalidOperationException("No even integers found in the file.");
            }
            double factorial = 1;
            for (int i = 1; i <= maxEvenInt; i++)
            {
                factorial *= i;
            }
            return Math.Round(factorial, 3);
        }
    }
}
