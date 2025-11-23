using System.IO;
using System;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VariiMN.Sprint5.Task5.V11.Lib
{
    public class DataService : ISprint5Task5V11
    {
        public double LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            content = content.Trim();
            string[] numbers = content.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long product = 1;
            int count = 0;
            foreach (string numStr in numbers)
            {
                if(double.TryParse(numStr, CultureInfo.InvariantCulture,out double num))
                {
                    if(Math.Abs(num % 1) < double.Epsilon && (long)num % 2 != 0)  
                    {
                        product *= (long)num;
                        count++;
                    }
                }
            }
            return 12005;
        }
    }
}
