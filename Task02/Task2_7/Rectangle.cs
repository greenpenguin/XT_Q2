namespace Task2_7
{
    public class Rectangle : Figure
    {
        private Point _a;
        private Point _b;
        private Point _c;
        private Point _d;

        public Rectangle(Point a, Point b, Point c, Point d)
        {
            this._a = a;
            this._b = b;
            this._c = c;
            this._d = d;
            ToString();
        }
        
        public string ToString()
        {
            return $"Created a rectangle based on point " + _a.ToString() + ", " + _b.ToString() + ", "
                + _c.ToString() + ", " + _d.ToString();
        }
    }
}