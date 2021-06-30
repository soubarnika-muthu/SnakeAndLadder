using System;

namespace SnakeAndLadder
{
    class Program
    {
        /// <summary>
        /// Snake and Ladder computation
        /// UC1-Initialize player and Initial position
        /// UC2- Generating Die Roll using Random class
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            //initializing local variable where no. of player is 1 and initial position is 0
            int player = 1;
            int playerPos = 0;
            //creating object for Random class
            Random random = new Random();

            //Generating DieRoll using Next method
            int dieRoll = random.Next(1, 7);

            Console.WriteLine("Welcome to Snake and Ladder World");
            Console.WriteLine("Player " + player + " is in position " + playerPos + " got number " + dieRoll);
            Console.Read();
        }


    }
}