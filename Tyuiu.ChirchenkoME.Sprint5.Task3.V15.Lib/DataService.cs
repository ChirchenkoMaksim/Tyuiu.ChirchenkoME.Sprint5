using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChirchenkoME.Sprint5.Task3.V15.Lib
{
    public class DataService : ISprint5Task3V15
    {
        public string SaveToFileTextData(int x)
        {
            //Дано выражение f(x) = -1.4x^3 + 2.3x^2 + 0.6x вычислить его значение при x = 5, результат сохранить в бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до трёх знаков после запятой.
            
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo FileInfo = new FileInfo(path);
            bool fileExists = FileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y = -1.4 * Math.Pow(x, 3) + 2.3 * Math.Pow(x, 2) + 0.6 * x;
            y = Math.Round(y, 3);
            using (BinaryWriter writer = new BinaryWriter(File
                    .Open(path, FileMode.Create)))
            {
                writer.Write(y);
            }
            return path;
        }
    }
}
