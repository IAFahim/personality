namespace personality.Game.Map
{
    public class Map
    {
        private TileType[][] _map;
        public TileType this[int i, int j]
        {
            get => _map[i][j];
            set => _map[i][j] = value;
        }
        
    }
}