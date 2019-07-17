namespace Task2_7
{
    public class Line : Figure
    {
        public Point PointA { get; set; }
        public Point PointB { get; set; }
        
        public Line(Point pointA, Point pointB)
        {
            this.PointA = pointA;
            this.PointB = pointB;
        }
        
        public string ToString()
        {
            return "Created the line based on points " + PointA.ToString() + " and " + PointB.ToString();
        }
    }
}