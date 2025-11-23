using Tyuiu.VariiMN.Sprint5.Task7.V3.Lib;
namespace Tyuiu.VariiMN.Sprint5.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Варий М.Н. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич. | ИСПб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InputDataFileTask7V1.txt                      *");
            Console.WriteLine("* Удалить все русские буквы из файла.Полученный результат сохранить в     *");
            Console.WriteLine("* OutPutDataFileTask7V1.txt                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string sourcePath = @"D:\DataSprint5\InputDataFileTask7V3.txt";

            string tempDirectory = Path.GetTempPath();
            string tempFileName = Path.GetFileName(sourcePath);
            string tempFilePath = Path.Combine(tempDirectory, tempFileName);

            File.Copy(sourcePath, tempFilePath, true);

            Console.WriteLine($"Файл скопирован в: {tempFilePath}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string result = ds.LoadDataAndSave(tempFilePath);

            string outputPath = Path.Combine(tempDirectory, "OutPutDataFileTask7V3.txt");
            File.WriteAllText(outputPath, result);

            Console.WriteLine($"Результат сохранён в: {outputPath}");
            Console.WriteLine("Содержимое результата:");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}