namespace Task2_7
{
    public class Round : Circle
    {
        private string Color { get; set; }
        public Round(Point center, double r, string color) : base(center, r)
        {
            this.Color = color;
            ToString();
        }
        
        public string ToString()
        {
            return $"Created a round with center in point " + _center.ToString() + ", radius = " + R 
                   + " and color is " + Color;
        }
    }
}