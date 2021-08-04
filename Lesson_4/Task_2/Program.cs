using System;

namespace Task_2
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел:");
            string str = Console.ReadLine();
            int num = 0;
            if (str != null)
            {
                string[] strArray = str.Split(" ", (StringSplitOptions) StringSplitOptions.None);
                int index = 0;
                while (true)
                {
                    if (index >= strArray.Length)
                    {
                        Console.WriteLine(num);
                        break;
                    }

                    string s = strArray[index];
                    num += int.Parse(s);
                    index++;
                }
            }
        }
    }
}
