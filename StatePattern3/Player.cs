
namespace StatePattern3
{
    class Player
    {
        private Position _currentPosition;
        public Position currentPosition
        {
            get
            {
                return _currentPosition;
            }
            set
            {
                _currentPosition = value;
            }
        }
        
        internal void Move(Position position)
        {
            _currentPosition = position;
        }

    }
}
