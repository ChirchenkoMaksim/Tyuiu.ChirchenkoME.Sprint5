using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChirchenkoME.Sprint5.Task7.V5.Lib
{
    public class DataService : ISprint5Task7V5
    {
        public string LoadDataAndSave(string path)
        {
            // Дан файл С:\DataSprint5\InPutDataFileTask7V5.txt (файл взять из архива согласно вашему варианту. Создать папку в ручную С:\DataSprint5\ и скопировать в неё файл) в котором есть набор символьных данных.Удалить все латинские буквы из файла.Полученный результат сохранить в файл OutPutDataFileTask7V5.txt.
            string content = File.ReadAllText(path);
            char[] resultChars = content.Where(c => !((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))).ToArray();
            string result = new string(resultChars);

            // Remove spaces that appear directly before punctuation (.,!?:;) and collapse multiple spaces, then trim
            string cleaned = Regex.Replace(result, @"\s+([.,!?:;])", "$1");
            cleaned = Regex.Replace(cleaned, @" {2,}", " ");
            cleaned = cleaned.Trim();

            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V5.txt");
            File.WriteAllText(outputPath, cleaned);
            return outputPath;
        }
    }
}
