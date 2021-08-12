using System;
using System.Globalization;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] stringItem =  { 
                {"ACZ","44","4GA","4HH"},
                { "1234A", "231", "411", "44" }, 
                { "ASDZZ", "dfa", "rhwqw", "55" }, 
                { "fhga", "a2134", "gazcv", "f41a" },

            };

            TestMethod(stringItem);

        }

        private static void TestMethod(string[,] stringItem)
        {
            try
            {
                if (stringItem.GetLength(0) != 4 && stringItem.GetLength(1) != 4)
                {
                    throw new MyArraySizeException(Error.Size);
                }

                for (int i = 0; i < stringItem.Length - 1; i++)
                {
                    for (int j = 0; j < stringItem[i, j].Length; j++)
                    {
                        if (!int.TryParse(stringItem[i, j], out var item))
                        {
                            throw new MyArrayDataException(Error.NotInt, i,j, stringItem);
                        }

                        Console.WriteLine(item += item);
                    }
                }
            }
            catch (MyArrayDataException e)
            {
                //var value = e.StringItems.GetValue(e.Column, e.Row);
                //string[,] newStringItem = new string[,]{};

                //var index = 0;

                //foreach (var item in newStringItem)
                //{
                    
                //    //if (ReferenceEquals(value, item))
                //    //{
                //    //    item.Remove(index);
                //    //}

                //    index++;
                //}

                //TestMethod(newStringItem);
            }
            catch (Exception e)
            {

            }
        }
    }
}
