using System;

namespace StatePattern3
{
    public class East : IPosition
    {
        public void Move(OOPlayer context)
        {
            context.SetState(new East());
            Console.WriteLine("Moved East!");
        }
    }
}
