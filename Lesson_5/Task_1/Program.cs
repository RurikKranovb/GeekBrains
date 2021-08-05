using System;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "task-1.txt";
            Console.WriteLine("Введите произвольный набор данных:");
            var readLine = Console.ReadLine();

            File.WriteAllText(fileName, readLine);
        }
    }
}
