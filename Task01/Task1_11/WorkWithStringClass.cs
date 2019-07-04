using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1_11
{
    public class WorkWithStringClass
    {
        public double CalculateAverageLength(List<int> lengths)
        {
            double lengthSum = lengths.ToArray().Sum();
            
            return lengthSum / lengths.Count;
        }
    }
}