using System;
using System.Collections.Generic;

namespace Task1_1
{
    public class WorkWithConsoleClass
    {
        public List<int> Input()
        {
            List<int> sidesLength = new List<int>();
            Console.WriteLine("Please, input the first side length");
            if (int.TryParse(Console.ReadLine(), out int firstSideLength))
            {
                if (firstSideLength > 0)
                {
                    sidesLength.Add(firstSideLength);
                }
                else
                {
                    throw new ArgumentException("The length must be greater than zero!");
                }
            }
            else
            {
                throw new ArgumentException("It's not an integer value!");
            }
            
            Console.WriteLine("Please, input the second side length");
            if (int.TryParse(Console.ReadLine(), out int secondSideLength))
            {
                if (secondSideLength > 0)
                {
                    sidesLength.Add(secondSideLength);
                }
                else
                {
                    throw new ArgumentException("The length must be greater than zero!");
                }
            }
            else
            {
                throw new ArgumentException("It's not an integer value!");
            }
            
            return sidesLength;
        }

        public void Output(int result)
        {
            Console.WriteLine("The area of this rectangle is " + result);
            
        }

    }
}