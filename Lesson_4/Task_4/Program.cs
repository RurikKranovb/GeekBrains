using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            string s = Console.ReadLine();
            if (s == null)
            {
                string local1 = s;
                throw new InvalidOperationException();
            }
            Console.WriteLine(Fibonachi(int.Parse(s)));

        }
        private static int Fibonachi(int n) =>
            ((n != 0) && (n != 1)) ? (Fibonachi(n - 1) + Fibonachi(n - 2)) : n;
    }
}
