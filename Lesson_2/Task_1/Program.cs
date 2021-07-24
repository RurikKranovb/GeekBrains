using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную темпиратуру:");
            var min = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите максимальную темпиратуру:");
            var max = double.Parse(Console.ReadLine());

            var average = (max + min) / 2;

            Console.WriteLine($"Среднесуточная температура: {average}");
        }
    }
}
