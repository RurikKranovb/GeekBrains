using System;
using System.Globalization;
using System.IO;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "startup.txt";

            string[] items = {Environment.NewLine, DateTime.Now.ToString("HH:mm:ss")};

            File.AppendAllLines(fileName, items);
        }
    }
}
