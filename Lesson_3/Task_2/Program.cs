using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = new string[5,2]
            {
                { "Имя:" ,"Телефон/Email" }, 
                { "Имя1:", "Телефон/Email1" }, 
                { "Имя2:", "Телефон/Email2" }, 
                { "Имя3:", "Телефон/Email3" }, 
                { "Имя4:", "Телефон/Email4" }
            };

            for (int i = 0; i < directory.GetLength(0); i++)
            {
                for (int j = 0; j < directory.GetLength(1); j++)
                {
                    Console.Write(directory[i,j]);
                }

                Console.WriteLine();

            }


        }
    }
}
