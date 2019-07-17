using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2_6
{
    public class WorkWithConsole
    {
        public List<double> InputRingData()
        {
            List<double> circleData = new List<double>();
            
            Console.WriteLine("Please, input X and Y coordinates of center and radius length of inner and outer rings.");
            string[] inputData = Console.ReadLine().Split(new[] {" ", "\n"}, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => item.Trim())
                .Where(item => !string.IsNullOrEmpty(item)).ToArray();

            if (inputData.Length == 6)
            {
                foreach (var s in inputData)
                {
                    if (!double.TryParse(s, out var value))
                    {
                        throw new ArgumentException("Wrong input data format!");
                    }
                    else
                    {
                        circleData.Add(value);
                    }
                }
            }
            else
            {
                throw new ArgumentException("You have to fill all fields!");
            }

            return circleData;
            
        }
        
        public void Output(double areaOfRing, double sumOfLength)
        {
            Console.WriteLine("Area of ring {0}", areaOfRing);
            Console.WriteLine("The sum of the lengths of the circles {0}", sumOfLength);
        }
    }
}