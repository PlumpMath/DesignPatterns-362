using System;

namespace StatePattern3
{
    class South : IPosition
    {
        public void Move(OOPlayer context)
        {
            context.SetState(new South());
            Console.WriteLine("Moved South!");
        }
    }
}
