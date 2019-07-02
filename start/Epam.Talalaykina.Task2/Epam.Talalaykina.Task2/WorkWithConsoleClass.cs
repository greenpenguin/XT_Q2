using System;

namespace Epam.Talalaykina.Task2
{
    public class WorkWithConsoleClass
    {
        public int[] InputArray()
        {
            int numOfArrayElements;
            Console.WriteLine("Please, input number of array's elements");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                numOfArrayElements = num;
            }
            else
            {
                throw new ArgumentException("It's not an integer value!");
            }
            
            int[] array = new int[numOfArrayElements];
            
            Console.WriteLine("Please, input " + numOfArrayElements + " elements of array");
            for (int i = 0; i < numOfArrayElements; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    array[i] = element;
                }
                else
                {
                    throw new ArgumentException("It's not an integer value!");
                }
            }

            return array;
        }

        public int InputSearchingElement()
        {
            int element;
            Console.WriteLine("Please, input element for searching");
            if (int.TryParse(Console.ReadLine(), out int elem))
            {
                element = elem;
            }
            else
            {
                throw new ArgumentException("It's not an integer value!");
            }

            return element;
        }

        public void OutputArrayWithMessage(int[] array, string message)
        {
            Console.WriteLine(message);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}