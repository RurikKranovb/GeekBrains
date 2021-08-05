using System;
using System.IO;
using System.Linq;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите с клавиатуры произвольный набор целых чисел (0...255):");

            var readLine = Console.ReadLine();

            var items = readLine?.Split(' ').Select(s => Convert.ToByte(s)).ToArray();

            File.WriteAllBytes("bytes.bin", items);
        }
    }
}
