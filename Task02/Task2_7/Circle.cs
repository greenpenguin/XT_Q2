namespace Task2_7
{
    public class Circle : Figure
    {
        public Point _center;
        public double R { get; set; }
        
        public Circle(Point center, double r)
        {
            this._center = center;
            this.R = r;
            ToString();
        }
        
        public string ToString()
        {
            return $"Created a circle with center in point " + _center.ToString() + " and radius = " + R;
        }
    }
}