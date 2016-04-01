using System;

namespace StatePattern3
{
    /*
     * you have a player.  That player may move up, down, left, or right.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Player
            Player p = new Player();
            p.Move(Position.North);
            Console.WriteLine(p.currentPosition);
            Console.ReadKey();
            p.Move(Position.South);
            Console.WriteLine(p.currentPosition);
            Console.ReadKey();
            p.Move(Position.East);
            Console.WriteLine(p.currentPosition);
            Console.ReadKey();
            p.Move(Position.West);
            Console.WriteLine(p.currentPosition);
            Console.ReadKey();
            p.Move(Position.South);
            Console.WriteLine(p.currentPosition);
            Console.ReadKey();


            // Now, try it using the State Pattern!
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Let's try it using a state pattern!");
            OOPlayer p2 = new OOPlayer();

            p2.SetState(new North());  // First, we set the state of the player
            p2.Move();                 // Then, we execute some instructions with the player.
            Console.ReadKey();
            p2.SetState(new South());
            p2.Move(); 
            Console.ReadKey();
            p2.SetState(new West());
            p2.Move(); 
            Console.ReadKey();
            p2.SetState(new East());
            p2.Move(); 
            Console.ReadKey();
            p2.SetState(new West());
            p2.Move(); 
            Console.ReadKey();
            p2.SetState(new West());
            p2.Move(); 
            Console.ReadKey();


        }
    }
}
