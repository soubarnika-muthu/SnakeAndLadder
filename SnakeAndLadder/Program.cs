using System;

namespace SnakeAndLadder
{
    class Program
    {
        /// <summary>
        /// Snake and Ladder computation
        /// UC1-Initialize player and Initial position
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            //initializing local variable where no. of player is 1 and initial position is 0
            int player = 1;
            int playerPos = 0;

            Console.WriteLine("Welcome to Snake and Ladder World");
            Console.WriteLine("Player " + player + " is in position " + playerPos + " initially");
            Console.Read();
        }
    }
}
