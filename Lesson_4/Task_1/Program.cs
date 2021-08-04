using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textArray1 = new string[]
                {"Фамилия Имя Отчество", "Фамилия Имя Отчество", "Фамилия Имя Отчество", "Фамилия Имя Отчество"};
            foreach (string str4 in textArray1)
            {
                string[] strArray3 = str4.Split(" ", (StringSplitOptions) StringSplitOptions.None);
                GetName(strArray3[0], strArray3[1], strArray3[2]);
            }

            Console.WriteLine("Введите имя:");
            Console.WriteLine("Введите фамилию:");
            Console.WriteLine("Введите отчество:");
            GetName(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());

        }

        private static void GetName(string firstName, string lastName, string patronymic)
        {
            string[] textArray1 = new string[] {(string) firstName, " ", (string) lastName, " ", (string) patronymic};
            Console.WriteLine(string.Concat((string[]) textArray1));
        }
    }
}
