﻿using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел:");
            var readLine = Console.ReadLine();

            var i = 0;
            if (readLine == null) return;
            foreach (var item in readLine.Split(" "))
            {
                i += int.Parse(item);
            }

            Console.WriteLine(i);


        }
    }
}
