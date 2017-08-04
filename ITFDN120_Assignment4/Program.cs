using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITFDN120_Assignment4
{
    class Program
    {
       static bool IsInArray(int startElement, int endElement, int elementToFind, int[] elements)
        {
            int index = (endElement + startElement) / 2;

            if (elements[index] == elementToFind)
            {
                return true;
            }

            //Go to the right
            if (elementToFind > elements[index])
            {
                return IsInArray(index + 1, endElement, elementToFind, elements);
            }

            //Go to the left
            if (elementToFind < elements[index])
            {
                return IsInArray(startElement, index - 1, elementToFind, elements);
            }

            return false;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 2, 8, 22, 44, 56, 65, 72, 101, 208, 452, 801 };

            Console.WriteLine(IsInArray(0, numbers.Length - 1, 22, numbers).ToString());
            Console.ReadLine();
        }
    }
}
