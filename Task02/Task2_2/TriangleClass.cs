using System;
using System.Collections.Generic;

namespace Task2_2
{
    public class TriangleClass
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        public TriangleClass(List<double> dataList)
        {
            if (IsMathErrorExists(dataList[0], dataList[1], dataList[2]))
            {
                throw new ArgumentException("The triangle doesn't exists!");
            }
            else
            {
                this.A = dataList[0];
                this.B = dataList[1];
                this.C = dataList[2];
            }
            
        }

        private bool IsMathErrorExists(double a, double b, double c)
        {
            if ((a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                return true;
            }

            return false;
        }

        public double GetPerimeter()
        {
            return A + B + C;
        }

        public double GetArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}