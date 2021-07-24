using System;

namespace SimpleConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите имя:");
            var name = Console.ReadLine();

            var date = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            Console.WriteLine($"Привет, {name}, сегодня {date}");
        }
    }
}
