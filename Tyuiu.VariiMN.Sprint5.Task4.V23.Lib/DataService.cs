using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VariiMN.Sprint5.Task4.V23.Lib
{
    public class DataService : ISprint5Task4V23
    {
        public double LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            content = content.Trim();
            double x = double.Parse(content, CultureInfo.InvariantCulture);
            double y = Math.Pow(x, -3) + 2 + Math.Cos(x);
            y = Math.Round(y, 3);
            return y;
        }
    }
}
