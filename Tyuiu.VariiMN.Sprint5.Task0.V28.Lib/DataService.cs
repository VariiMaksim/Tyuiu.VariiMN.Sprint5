using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VariiMN.Sprint5.Task0.V28.Lib
{
    public class DataService : ISprint5Task0V28
    {
        public string SaveToFileTextData(int x)
        {
            double y = x * Math.Sqrt(x + 3);
            y = Math.Round(y, 3);
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask0.txt";
            string filePath = Path.Combine(tempPath, fileName);

            File.WriteAllText(filePath, y.ToString());

            return filePath;
        }
    }
}
