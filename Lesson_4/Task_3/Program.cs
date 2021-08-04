using System;

namespace Task_3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца:");
            try
            {
                int num = ReadLine();
                while (true)
                {
                    if ((num <= 12) && (num >= 1))
                    {
                        NumberMonth(num);
                        break;
                    }
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                    num = ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ну ты ваще =)");
                Console.WriteLine("Еще 1 попытка");
                int num2 = ReadLine();
                while (true)
                {
                    if ((num2 <= 12) && (num2 >= 1))
                    {
                        NumberMonth(num2);
                        break;
                    }
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                    num2 = ReadLine();
                }
            }

        }

        private static void NumberMonth(in int num2)
        {
            switch (num2)
            {
                case 12:
                case 1:
                case 2:
                    WriteSeason(SeasonsEnum.Winter);
                    break;
                case 3:
                case 4:
                case 5:
                    WriteSeason(SeasonsEnum.Spring);
                    break;
                case 6:
                case 7:
                case 8:
                    WriteSeason(SeasonsEnum.Summer);
                    break;
                case 9:
                case 10:
                case 11:
                    WriteSeason(SeasonsEnum.Autumn);
                    break;
                default:
                    break;
            }
        }

        private static int ReadLine()
        {
            string s = Console.ReadLine();
            if (s == null)
            {
                string local1 = s;
                throw new InvalidOperationException();
            }
            return int.Parse(s);
        }



        private static void WriteSeason(SeasonsEnum winter)
        {
            switch (winter)
            {
                case SeasonsEnum.Winter:
                    Console.WriteLine("Зима");
                    break;

                case SeasonsEnum.Spring:
                    Console.WriteLine("Весна");
                    break;

                case SeasonsEnum.Summer:
                    Console.WriteLine("Лето");
                    break;

                case SeasonsEnum.Autumn:
                    Console.WriteLine("Осень");
                    break;

                default:
                    throw new ArgumentOutOfRangeException("winter", winter, null);
            }
        }
    }





    internal enum SeasonsEnum
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }


}
