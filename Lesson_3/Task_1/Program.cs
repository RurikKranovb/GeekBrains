using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new int[15, 15];

            for (var i = 0; i < items.GetLength(0); i++)
            {
                for (var j = 0; j < items.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        items[i, j] = j;
                        Console.Write($"{items[i, j]}");
                    }
                    else
                    {
                        Console.Write($" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
