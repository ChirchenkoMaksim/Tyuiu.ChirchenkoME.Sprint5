using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChirchenkoME.Sprint5.Task2.V18.Lib
{
    public class DataService : ISprint5Task2V18
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            // Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями с клавиатуры. Заменить положительные элементы массива на 1, отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль. 3; 8; 4 - 5; -4; -3 - 9; 0; 2
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo FileInfo = new FileInfo(path);
            bool fileExists = FileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                string line = "";
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }
                    line += matrix[i, j].ToString();
                    if (j < columns - 1)
                    {
                        line += ";";
                    }
                }
                File.AppendAllText(path, line + "\n");
            }
            return path;

        }
    }
}
