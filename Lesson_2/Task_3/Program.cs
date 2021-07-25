using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите целое число:");

            var number = Console.ReadLine();

            var isInt = int.TryParse(number, out var item);

            if (isInt)
            {
                Console.WriteLine(item % 2 == 0 ? "Число четное" : "Число нечетное");
            }
            else
            {
                Console.WriteLine("Число не четное!");
            }
        }
    }
}
