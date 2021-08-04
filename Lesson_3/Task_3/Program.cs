using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = "Hello";

            var items = new char[item.Length];


            for (var i = 0; i < items.Length; i++)
            {
                items[i] = item[item.Length - 1 - i];

                Console.WriteLine(items);
            }
        }
    }
}
