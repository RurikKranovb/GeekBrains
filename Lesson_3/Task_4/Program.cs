using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var poligon = new int[10,10];

            var little = new int[4, 1];
            var average = new int[3, 2];
            var big = new int[1, 4];

            for (var i = 0; i < poligon.GetLength(0); i++)
            {
                for (var j = 0; j < poligon.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        poligon[i, j] = j;
                        Console.Write($"{poligon[i, j]}");
                    }
                    else
                    {
                        Console.Write($"*");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
