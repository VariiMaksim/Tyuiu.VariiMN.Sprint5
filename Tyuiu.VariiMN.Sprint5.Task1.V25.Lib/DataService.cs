using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VariiMN.Sprint5.Task1.V25.Lib
{
    public class DataService : ISprint5Task1V25
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask1.txt";
            string filePath = Path.Combine(tempPath, fileName);
            string fileContent = "";

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx = 0.0;

                double denominator = 3.0 * x + 1.2;

                if (denominator == 0)
                {
                    fx = 0.0;
                }
                else
                {
                    fx = (2 * Math.Sin(x)/ denominator) + Math.Cos(x) - 7 * x * 2;
                }

                fx = Math.Round(fx, 2);
                fileContent += fx.ToString() + "\n";
            }

            File.WriteAllText(filePath, fileContent);

            return filePath;
        }
    }
}
