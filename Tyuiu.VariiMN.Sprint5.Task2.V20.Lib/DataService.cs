using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VariiMN.Sprint5.Task2.V20.Lib
{
    public class DataService : ISprint5Task2V20
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask2.csv";
            string filePath = Path.Combine(tempPath, fileName);

            string fileContent = "";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j] > 0)
                        matrix[i, j] = 1;
                    if (matrix[i, j] < 0)
                        matrix[i, j] = 0;
                    

                    fileContent += matrix[i, j];
                    if (j < 2) fileContent += ";"; 
                }
                if (i < 2) fileContent += "\n"; 
            }

            File.WriteAllText(filePath, fileContent);

            return filePath;
        }
    }
}
