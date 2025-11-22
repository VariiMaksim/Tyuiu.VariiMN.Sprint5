using Tyuiu.VariiMN.Sprint5.Task1.V25.Lib;
namespace Tyuiu.VariiMN.Sprint5.Task1.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Варий М. Н. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File.                                                       *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич. | ИСПб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение: y = x * sqrt(x + 3)                                     *");
            Console.WriteLine("* Вычислить его значение при x=3, результат сохранить в файл              *");
            Console.WriteLine("* OutPutFileTask0.txt и вывести на консоль. Округлить до трёх знаков.     *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("startValue" + startValue);
                Console.WriteLine("stopValue" + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string filePath = ds.SaveToFileTextData(startValue, stopValue);


            string content = File.ReadAllText(filePath);
            string[] values = content.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("+-------+--------+");
            Console.WriteLine("|   x   |  f(x)  |");
            Console.WriteLine("+-------+--------+");

            for (int i = 0; i < values.Length; i++)
            {
                int x = startValue + i;
                Console.WriteLine($"|  {x,3}  | {values[i],6} |");
            }

            Console.WriteLine($"Файл сохранён по пути: {filePath}");

            Console.ReadKey();
        }
    }
}