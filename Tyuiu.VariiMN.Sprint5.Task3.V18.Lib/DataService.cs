using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;



namespace Tyuiu.VariiMN.Sprint5.Task3.V18.Lib
{
    public class DataService : ISprint5Task3V18
    {
        public string SaveToFileTextData(int x)
        {
            double dx = x;
            double y = 2.12 * Math.Pow(dx, 3) + 1.05 * Math.Pow(dx, 2) + 4.1 * dx * 2;
            y = Math.Round(y, 3);

            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask3.bin";
            string filePath = Path.Combine(tempPath, fileName);

            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(y);
            }

            return filePath;
        }
    }
}
