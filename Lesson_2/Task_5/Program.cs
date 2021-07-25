using System;
using System.Globalization;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var average = Average();

            Console.WriteLine("Введите номер текущего месяца:");
            var numberMonth = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            if (numberMonth == 12 || numberMonth == 1 || numberMonth == 2 && average >= 0)
            {
                Console.WriteLine("Дождливая зима");
            }
        }

        private static double Average()
        {
            Console.WriteLine("Введите минимальную темпиратуру:");

            var readLineMin = Console.ReadLine();

            var min = MinTemp(readLineMin, out var isMin);


            if (!isMin)
            {
                Console.WriteLine("Неверный формат, использовать запятую");

                readLineMin = Console.ReadLine();
                min = MinTemp(readLineMin, out isMin);
            }


            Console.WriteLine("Введите минимальную темпиратуру:");


            var readLineMax = Console.ReadLine();
            var max = MaxTemp(readLineMax, out var isMax);


            if (!isMax)
            {
                Console.WriteLine("Неверный формат, использовать запятую");
                readLineMax = Console.ReadLine();
                max = MaxTemp(readLineMax, out isMax);
            }


            return (max + min) / 2;
        }

        private static double MaxTemp(string readLine, out bool o)
        {

            o = double.TryParse(readLine, out var resultMin);

            return resultMin;
        }

        private static double MinTemp(string result, out bool isDouble)
        {
            isDouble = double.TryParse(result, out var resultMin);

            return resultMin;
        }
    }

}
