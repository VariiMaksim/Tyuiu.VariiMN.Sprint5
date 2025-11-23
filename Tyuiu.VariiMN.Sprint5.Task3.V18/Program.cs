using Tyuiu.VariiMN.Sprint5.Task3.V18.Lib;
namespace Tyuiu.VariiMN.Sprint5.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Варий М.Н. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич. | ИСПб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение: F(x) = 2.12x^3+1.05x^2+4.1x*2                           *");
            Console.WriteLine("* Вычислить его значение при x=5, результат сохранить в бинарный файл     *");
            Console.WriteLine("* OutPutFileTask3.bin и вывести на консоль. Округлить до трёх знаков.     *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;

            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string filePath = ds.SaveToFileTextData(x);

            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                double result = reader.ReadDouble();
                Console.WriteLine($"Результат: {result:F3}");
            }

            Console.WriteLine($"Файл сохранён по пути: {filePath}");

            Console.ReadKey();
        }
    }
}