using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
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
    

            var average = (max + min) / 2;

            Console.WriteLine($"Среднесуточная температура: {average}");
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
