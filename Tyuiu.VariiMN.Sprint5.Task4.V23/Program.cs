using Tyuiu.VariiMN.Sprint5.Task4.V23.Lib;
namespace Tyuiu.VariiMN.Sprint5.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Варий М.Н. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич. | ИСПб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask4V0.txt                      *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо X в формулу:            *");
            Console.WriteLine("* y = (x^-3 + 2 + cos(x)                                                  *");
            Console.WriteLine("* Вычислить значение, округлить до трёх знаков и вывести на консоль.      *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"D:\DataSprint5\InPutDataFileTask4V23.txt";

            Console.WriteLine("Файл для чтения: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.LoadFromDataFile(path);
            Console.WriteLine($"Результат: {result:F3}");

            Console.ReadKey();
        }
    }
}