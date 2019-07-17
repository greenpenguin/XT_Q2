namespace Task2_8
{
    public class Player : IAction
    {
        private int _positionX;
        private int _positionY;
        private int _healthPoint;
        private Bonus[] _bonuses;
        
        private int PositionX
        {
            get => _positionX; 
            set => _positionX = value; 
        }
        
        private int PositionY
        {
            get => _positionY; 
            set => _positionY = value; 
        }

        private int HealthPoint
        {
            get => _healthPoint;
            set => _healthPoint = value;
        }

        public Player(int positionX, int positionY, int healthPoint, Bonus[] bonuses)
        {
            this.PositionX = positionX;
            this.PositionY = positionY;
            this.HealthPoint = healthPoint;
            this._bonuses = bonuses;
        }
        
        public void GoUp()
        {
            
        }
        
        public void GoDown()
        {
            
        }
        
        public void GoRight()
        {
            
        }
        
        public void GoLeft()
        {
            
        }
        
    }
}