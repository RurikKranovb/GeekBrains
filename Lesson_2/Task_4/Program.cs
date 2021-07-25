using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {

            var date = DateTime.Now;
            var money = 1000;

            Console.WriteLine("Кассовый чек/приход");
            Console.WriteLine("РН ККТ: ****************");
            Console.WriteLine("ФН: ****************");
            Console.WriteLine(date);
            Console.WriteLine("Сайт ФНС:    nalog.ru");
            Console.WriteLine("Смена: 127 ЧЕК: 197");
            Console.WriteLine($"ИТОГО: {money}");
        }
    }
}
