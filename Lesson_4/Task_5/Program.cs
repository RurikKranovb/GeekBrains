using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str2 = " Предложение один Теперь предложение два Предложение три";
            bool flag = true;
            int num = 0;
            while (true)
            {
                if (num >= (str2.Length - 1))
                {
                    Console.WriteLine(str2.Insert(0, "").Trim() + ".");
                    return;
                }
                char c = str2[num];
                if (char.IsUpper(c) && (str2[num - 1] == ' '))
                {
                    if (flag)
                    {
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                        str2 = str2.Insert(num - 1, ".");
                    }
                }
                num++;
            }
        }
    }
}
