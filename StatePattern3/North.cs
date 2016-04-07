using System;

namespace StatePattern3
{
    class North : IPosition
    {
        public void Move(OOPlayer context)
        {
            context.SetState(this);
            Console.WriteLine("moved North");
        }
    }
}
