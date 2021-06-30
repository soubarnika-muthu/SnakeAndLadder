
  
  
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
        /// </summary>
        /// <param name="args">The arguments.</param>


        const int LADDER = 2;
        const int SNAKE = 1;
        const int NO_PLAY = 0;
        


        static void Main(string[] args)
        {
            //initializing local variable where no. of player is 1 and initial position is 0
            int player = 1;
            int playerPos = 0;

            //creating object for Random class
            Random random = new Random();

            //Generating DieRoll using Next method
            int dieRoll = random.Next(1, 7);

            //Generating the player choice
            int playerChoice = random.Next(0, 3);


            Console.WriteLine("Welcome to Snake and Ladder World");
            Console.WriteLine("Player " + player + " is in position " + playerPos + " initially");
            PlayerChoice(playerChoice,dieRoll,playerPos);
            Console.Read();

        }
            //method check whether snake or ladder
            public static void PlayerChoice(int choice,int die,int playerPos)
            {
                switch (choice)
                {
                    case LADDER:
                        playerPos+= die;
                        Console.WriteLine("Ladder moved Forward to the postion "+playerPos);
                        break;
                    case SNAKE:
                        playerPos += die;
                        Console.WriteLine("Snake moved Backward to the postion " + playerPos);
                        break;
                    default:
                        playerPos = 0;
                        Console.WriteLine("Don't Move");
                        break;
                }
            }


        }
    }

