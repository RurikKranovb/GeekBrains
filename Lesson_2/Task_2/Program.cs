using System;
using System.Globalization;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер текущего месяца:");
            var numberMonth = Console.ReadLine();

            Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(numberMonth)));
        }
    }
}
