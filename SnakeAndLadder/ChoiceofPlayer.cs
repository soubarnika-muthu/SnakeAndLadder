using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class ChoiceOfPlayer
    {
        public const int LADDER = 2;
        const int SNAKE = 1;
        const int NO_PLAY = 0;
        public const int WIN = 100;
        public const int INITIAL_POS = 0;
        //method check whether snake or ladder
        public static int PlayerChoice(int choice, int position, int die)
        {
            switch (choice)
            {
                case LADDER:
                    position += die;
                    break;
                case SNAKE:
                    position -= die;
                    break;
                default:
                    break;
            }

            position = Restart(position);
            position = ExactWinCheck(position, die);

            return position;
        }

        //if position reaches below initial pos restart from initial pos
        private static int Restart(int pos)
        {
            if (pos < INITIAL_POS)
            {
                pos = 0;
            }
            return pos;
        }

        //Checks whether the position is within WIN
        private static int ExactWinCheck(int lastPos, int die)
        {
            if (lastPos > WIN)
            {
                lastPos -= die;
            }
            return lastPos;
        }
    }
}
