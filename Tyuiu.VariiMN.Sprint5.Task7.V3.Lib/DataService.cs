using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VariiMN.Sprint5.Task7.V3.Lib
{
    public class DataService : ISprint5Task7V3
    {
        public string LoadDataAndSave(string path)
        {
            string content = File.ReadAllText(path);
            string result = Regex.Replace(content, "[а-яёА-ЯЁ]", "");
            return result;
        }
    }
}
