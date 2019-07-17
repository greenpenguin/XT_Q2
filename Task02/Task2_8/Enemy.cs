namespace Task2_8
{
    public class Enemy: IAction
    {
        private int _positionX;
        private int _positionY;
        private int _hitPoint;
        
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

        private int HitPoint
        {
            get => _hitPoint;
            set => _hitPoint = value;
        }

        public Enemy(int positionX, int positionY, int hitPoint)
        {
            this.PositionX = positionX;
            this.PositionY = positionY;
            this.HitPoint = hitPoint;
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

        public void Hit()
        {
            
        }
    }
}