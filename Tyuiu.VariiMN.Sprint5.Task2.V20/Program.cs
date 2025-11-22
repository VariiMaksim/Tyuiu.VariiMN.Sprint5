using Tyuiu.VariiMN.Sprint5.Task2.V20.Lib;
namespace Tyuiu.VariiMN.Sprint5.Task2.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Варий М. Н. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич. | ИСПб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элемента, заполненный         *");
            Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1,  *");
            Console.WriteLine("* отрицательные на 0.                                                     *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите 9 целых чисел через запятую: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

            if (numbers.Length != 9)
            {
                Console.WriteLine("Ошибка: введите ровно 9 чисел.");
                Console.ReadKey();
                return;
            }

            int[,] matrix = new int[3, 3];
            int index = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = int.Parse(numbers[index]);
                    index++;
                }
            }

            Console.WriteLine("\nИсходный массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j]);
                    if (j < 2) Console.Write("; ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string filePath = ds.SaveToFileTextData(matrix);

            Console.WriteLine("Массив после замены положительных элементов массива на 1, отрицательные на 0:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j]);
                    if (j < 2) Console.Write("; ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nФайл сохранён по пути: {filePath}");

            Console.ReadKey();
        }
    }
}