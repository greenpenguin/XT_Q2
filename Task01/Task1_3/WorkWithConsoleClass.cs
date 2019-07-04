using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_3
{
    public class WorkWithConsoleClass
    {
        public int Input()
        {
            int number;
            Console.WriteLine("Please, input an odd number that is greater than zero");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num > 0)
                {
                    if (num % 2 == 0)
                    {
                        throw new ArgumentException("The number is even!");
                    }
                    else
                    {
                        number = num;
                    }
                }
                else
                {
                    throw new ArgumentException("The number must be greater than zero!");
                }
            }
            else
            {
                throw new ArgumentException("It's not an integer value!");
            }
            
            return number;
        }

        public void Output(List<StringBuilder> resultList)
        {
            foreach (var element in resultList)
            {
                Console.Write(element);
            }
        }
    }
}