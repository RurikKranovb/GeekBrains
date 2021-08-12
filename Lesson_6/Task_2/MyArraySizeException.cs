using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Task_2
{
    class MyArraySizeException : Exception
    {
        public Error Error { get; }
        public MyArraySizeException(Error error)
        {
            Error = error;
        }
    }
}
