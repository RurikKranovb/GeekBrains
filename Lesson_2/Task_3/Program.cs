using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine(number % 2 == 0 ? "Число четное" : "Число нечетное");
        }
    }
}
