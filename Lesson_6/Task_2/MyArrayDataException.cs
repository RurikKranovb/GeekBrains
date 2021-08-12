using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    sealed class MyArrayDataException: Exception
    {
        public Error Error { get; }

        public int Column { get; set; }
        public int Row { get; set; }

        public string[,] StringItems { get; set; }
        public MyArrayDataException(Error error, int column, int row, string[,] stringItem)
        {
            Error = error;

            StringItems = stringItem;
            Column = column;
            Row = row;

            Console.WriteLine($"column: {column}");
            Console.WriteLine($"row: {row}");
        }
    }
}
