
namespace StatePattern3
{
    public class OOPlayer
    {
        private IPosition _currentPosition;

        public OOPlayer()
        {
            _currentPosition = new NoMove();
        }

        public void SetState(IPosition position)
        {
            _currentPosition = position;
        }

        public void Move()
        {
            _currentPosition.Move(this);
        }
    }
}
