using System;
using System.Collections.Generic;

namespace Task2_1
{
    public class WorkWithConsoleClass
    {
        public List<double> Input()
        {
            List<double> dataList = new List<double>();
            
            Console.WriteLine("Please, enter the first coordinate of the center");
            if (double.TryParse(Console.ReadLine(), out double xCoordinate))
            {
                dataList.Add(xCoordinate);
            }
            else
            {
                throw new ArgumentException("It's not an double value!");
            }
            
            Console.WriteLine("Please, enter the second coordinate of the center");
            if (double.TryParse(Console.ReadLine(), out double yCoordinate))
            {
                dataList.Add(yCoordinate);
            }
            else
            {
                throw new ArgumentException("It's not an double value!");
            }
            
            Console.WriteLine("Please, input the radius length");
            if (double.TryParse(Console.ReadLine(), out double radiusLength))
            {
                if (radiusLength > 0)
                {
                    dataList.Add(radiusLength);
                }
                else
                {
                    throw new ArgumentException("The radius length must be greater than zero!");
                }
            }
            else
            {
                throw new ArgumentException("It's not an double value!");
            }
            
            return dataList;
        }

        public void Output(double areaOfRound, double lengthOfRound)
        {
            Console.WriteLine("The area of round " + areaOfRound);
            Console.WriteLine("The lengths of the round " + lengthOfRound);
        }
    }
}