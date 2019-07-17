namespace Task2_8
{
    public class Bonus : StaticGameObject
    {
        private string Name
        {
            get => _name;
            set => _name = value;
        }
        
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

        public Bonus(string name, int positionX, int positionY)
        {
            this.Name = name;
            this.PositionX = positionX;
            this.PositionY = positionY;
        }

        public void BonusDoSomething()
        {
            
        }

    }
}