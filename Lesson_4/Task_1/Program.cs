using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = {"Фамилия Имя Отчество", "Фамилия Имя Отчество", "Фамилия Имя Отчество", "Фамилия Имя Отчество"};

            foreach (var item in items)
            {
                var strings = item.Split(" ");

                GetName(strings[0], strings[1], strings[2]);
            }

            Console.WriteLine("Введите имя:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Введите отчество:");
            var patronymic = Console.ReadLine();

            GetName(firstName, lastName, patronymic);
        }

        private static void GetName(string firstName, string lastName, string patronymic)
        {
            Console.WriteLine($"{firstName} {lastName} {patronymic}");
        }
    }
}