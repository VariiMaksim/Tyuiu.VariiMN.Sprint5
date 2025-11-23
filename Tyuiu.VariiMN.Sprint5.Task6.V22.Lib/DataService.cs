using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VariiMN.Sprint5.Task6.V22.Lib
{
    public class DataService : ISprint5Task6V22
    {
        public int LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);

            int count = 0;

            for (int i = 0; i < content.Length - 1; i++)
            {
                if (content[i] == 'м' && content[i + 1] == 'м')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
