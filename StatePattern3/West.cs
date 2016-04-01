using System;

namespace StatePattern3
{
    class West : IPosition
    {
        public void Move(OOPlayer context)
        {
            context.SetState(new West());
            Console.WriteLine("Moved West young man!");
        }
    }
}
