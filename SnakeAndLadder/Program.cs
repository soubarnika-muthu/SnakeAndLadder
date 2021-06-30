
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
        /// </summary>
        /// <param name="args">The arguments.</param>


        const int LADDER = 2;
        const int SNAKE = 1;
        const int NO_PLAY = 0;
        const int WIN = 100;
        const int INITIAL_POS = 0;


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder World");

            //initializing local variable where no. of player is 1 and initial position is 0
           // int player = 1;
            int playerPos = INITIAL_POS;
            //creating object for Random class
            Random random = new Random();

            //playing till the player reaches Win position
            while (playerPos < WIN)
            {
                //Generating DieRoll using Next method
                int dieRoll = random.Next(1, 7);

                //Generating the player choice
                int playerChoice = random.Next(0, 3);

                //current position of player
                playerPos = PlayerChoice(playerChoice, playerPos, dieRoll);
                Console.WriteLine("Player Position:" + playerPos);


            }


            Console.Read();
        }

        //method check whether snake or ladder
        public static int PlayerChoice(int choice, int pos, int die)
        {
            switch (choice)
            {
                case LADDER:
                    pos += die;
                    break;
                case SNAKE:
                    pos -= die;
                    break;
                default:
                    break;
            }

            //if position reaches below initial pos restart from initial pos
            if (pos < INITIAL_POS)
            {
                pos = 0;
            }

            pos = ExactWinCheck(pos, die);

            return pos;
        }

        //Checks whether the position is within WIN
        public static int ExactWinCheck(int lastPos, int die)
        {
            if (lastPos > WIN)
            {
                lastPos -= die;
            }
            return lastPos;
        }

    }
}
