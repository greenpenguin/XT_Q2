using System;
using System.Collections.Generic;

namespace Task2_2
{
    public class WorkWithConsoleClass
    {
        public List<double> Input()
        {
            List<double> dataList = new List<double>();
            
            Console.WriteLine("Please, input the first side length");
            if (double.TryParse(Console.ReadLine(), out double firstSideLength))
            {
                if (firstSideLength > 0)
                {
                    dataList.Add(firstSideLength);
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
            if (double.TryParse(Console.ReadLine(), out double secondSideLength))
            {
                if (secondSideLength > 0)
                {
                    dataList.Add(secondSideLength);
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
            
            Console.WriteLine("Please, input the third side length");
            if (double.TryParse(Console.ReadLine(), out double thirdSideLength))
            {
                if (thirdSideLength > 0)
                {
                    dataList.Add(thirdSideLength);
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
            
            return dataList;
        }

        public void Output(double area, double perimeter)
        {
            Console.WriteLine("The area of the triangle " + area);
            Console.WriteLine("The perimeter of the triangle " + perimeter);
        }
    }
}