using System;
using System.Diagnostics;
using System.Linq;

namespace Task_1
{
    class Program
    {
        private static int _topIndex;
        private static int _leftIndex;

        static void Main(string[] args)
        {
            var getProcesses = Process.GetProcesses();

            var itemsShow = new[] {"Name:", "ID:"};

            foreach (var item in itemsShow)
            {
                ShowGrid(_leftIndex, _topIndex, item);

                LeftIndex();
            }

            for (int i = 0; i < getProcesses.Length - 1; i++)
            {
                _leftIndex = 0;

                var item = getProcesses[i];

                var items = new[] {item.ProcessName, item.Id.ToString()};
                _topIndex = 2 + i;

                ShowProc(items);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Укажите имя или ID процесса для его завершения:");
            var procName = Console.ReadLine();
            try
            {
                var item = int.Parse(procName ?? throw new InvalidOperationException());

                getProcesses.FirstOrDefault(process => process?.Id == item)?.Kill();
            }
            catch (System.FormatException e)
            {
                getProcesses.FirstOrDefault(process => process?.ProcessName == procName)?.Kill();
            }
            catch
            {
                // Знаю, плохо...
            }
        }

        private static void LeftIndex()
        {
            _leftIndex += 50;
        }

        private static void ShowGrid(int leftIndex, int topIndex, string item)
        {
            Console.SetCursorPosition(leftIndex, topIndex);
            Console.Write(item);
        }

        private static void ShowProc(string[] items)
        {
            foreach (var item in items)
            {
                ShowGrid(_leftIndex, _topIndex, item);

                LeftIndex();
            }
        }
    }
}
