using System;
using System.Collections.Generic;

namespace Task2_7
{
    public class Ring : Figure
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
                if (!IsMathErrorsExists(value._center.X, value._center.Y, value.R, 
                    _outerCircle._center.X, _outerCircle._center.Y, _outerCircle.R))
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
                if (!IsMathErrorsExists(_innerCircle._center.X, _innerCircle._center.Y, _innerCircle.R, 
                    value._center.X, value._center.Y, value.R))
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
                Point innerCenter = new Point(dataList[0], dataList[1]);
                Point outerCenter = new Point(dataList[3], dataList[4]);
                this._innerCircle = new Circle(innerCenter, dataList[2]);
                this._outerCircle = new Circle(outerCenter, dataList[5]);
            }
            else 
            {
                throw new ArgumentException("MATH ERROR!");
            }
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
        
        public string ToString()
        {
            return $"Created a ring:" 
                   + Environment.NewLine + "Inner circle: center in point (" 
                   + _innerCircle._center.X + ", " + _innerCircle._center.Y + ") and radius = " + _innerCircle.R
                   + Environment.NewLine + "Outer circle: center in point (" 
                   + _outerCircle._center.X + ", " + _outerCircle._center.Y + ") and radius = " + _outerCircle.R;
        }
    }
}