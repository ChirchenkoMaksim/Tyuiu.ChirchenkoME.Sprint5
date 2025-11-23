using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChirchenkoME.Sprint5.Task6.V25.Lib
{
    public class DataService : ISprint5Task6V25
    {
        public int LoadFromDataFile(string path)
        {
            //Дан файл С:\DataSprint5\InPutDataFileTask6V25.txt (файл взять из архива согласно вашему варианту. Создать папку в ручную С:\DataSprint5\ и скопировать в неё файл) в котором есть набор символьных данных.Найти количество знаков восклицания в заданной строке.
            string content = File.ReadAllText(path);
            int count = 0;
            foreach (char c in content)
            {
                if (c == '!')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
