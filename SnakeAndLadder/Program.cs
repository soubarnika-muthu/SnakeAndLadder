using System;

namespace SnakeAndLadder
{
    class Program
    {

        /// <summary>
        /// Snake and Ladder computation
        /// UC1-Initialize player and Initial position
        /// UC2- Generating Die Roll using Random class
        /// UC3- Checking whether to move forward backward based on player choice
        /// UC4- Checking till reaches 100
        /// UC5-Checks for Exact Win 
        /// UC6- Display number of time to reach the win and position
        /// </summary>
        /// <param name="args">The arguments.</param>

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder World");

            //create the object for class 
            SnakeAndLadderGame snakeAndLadderGame = new SnakeAndLadderGame();

            //calling the method that execute the process of dualplayer game
            snakeAndLadderGame.StepToWin();

            Console.Read();
        }

    }

}
