using System;
using System.Collections.Generic;

namespace Task2_6
{
    public class Ring
    {
        private Circle _innerCircle;
        private Circle _outerCircle;

        public Ring(List<double> dataList)
        {
            Assert(dataList);
        }
        
        public Circle InnerCircle
        {
            get
            {
                return _innerCircle;
            }
            set
            {
                if (!IsMathErrorsExists(value.X, value.Y, value.R, _outerCircle.X, _outerCircle.Y, _outerCircle.R))
                {
                    _innerCircle = value;
                }
                else
                {
                    throw new ArgumentException("MATH ERROR!");
                }
            }
        }
        
        public Circle OuterCircle
        {
            get
            {
                return _outerCircle;
            }
            set
            {
                if (!IsMathErrorsExists(_innerCircle.X, _innerCircle.Y, _innerCircle.R, value.X, value.Y, value.R))
                {
                    _outerCircle = value;
                }
                else
                {
                    throw new ArgumentException("MATH ERROR!");
                }
            }
        }
        
        public void Assert(List<double> dataList)
        { 
            if (!IsMathErrorsExists(dataList[0], dataList[1], dataList[2], dataList[3], dataList[4], dataList[5]))
            {
                this._innerCircle = new Circle(dataList[0], dataList[1], dataList[2]);
                this._outerCircle = new Circle(dataList[3], dataList[4], dataList[5]);
            }
            else 
            {
                throw new ArgumentException("MATH ERROR!");
            }
        }

        public double AreaOfRing()
        {
            return ( (OuterCircle.R * OuterCircle.R) - (InnerCircle.R * InnerCircle.R) ) * Math.PI;
        }

        public double SumOfLengthsOfCircles()
        {
            return ( OuterCircle.R + InnerCircle.R ) * 2 * Math.PI;
        }

        private bool IsMathErrorsExists(double innerX, double innerY, double innerR, double outerX, double outerY, double outerR)
        {
            if ((innerX != outerX) || (innerY != outerY))
            {
                return true;
            }

            if ((innerR < 0) || (outerR < 0))
            {
                return true;
            }
            
            if (innerR > outerR)
            {
                return true;
            }

            return false;
        }
    }
}