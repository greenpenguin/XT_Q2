namespace Task2_8
{
    public class Map
    {
        private int _width;
        private int _height;

        private Player _player;
        private Enemy _enemies;
        private Bonus[] _bonuses;
        private Obstacles[] _obstacles;

        private int Width
        {
            get => _width;
            set => _width = value;
        }

        private int Height
        {
            get => _height;
            set => _height = value;
        }

        public Map(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public void LoadPlayer()
        {
            
        }

        public void LoadEnemis()
        {
            
        }
        
        public void LoadGameObjects()
        {
            
        }
        
        
    }
}