using System;
using System.Collections.Generic;

namespace Task2_1
{
    public class RoundClass
    {
        private double X { get; set; }
        private double Y { get; set; }
        private double R { get; set; }

        public RoundClass(List<double> dataList)
        {
            this.X = dataList[0];
            this.Y = dataList[1];
            this.R = dataList[2];
        }

        public double GetLengthOfRound()
        {
            return 2 * Math.PI * R;
        }
        
        public double GetAreaOfRound()
        {
            return R * R * Math.PI;
        }
    }
}