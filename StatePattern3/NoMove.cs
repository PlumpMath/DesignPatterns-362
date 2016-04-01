using System;

namespace StatePattern3
{
    class NoMove : IPosition
    {
        public void Move(OOPlayer context)
        {
            context.SetState(this);
            Console.WriteLine("Didn't move");
        }
    }
}