using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinGame
{
    public class Goblin : Enemy
    {

        public Goblin (int x, int y) : base (x,y,1,10,'G')                               //Constructor Aquiring variables from Enemy Class
        {
            
        }

        public override Movement ReturnMove(Movement move = 0)
        {

           

            int rand = rnd.Next(0, 4);                          //Switch Case to determine the movement (or lack thereof) of the Goblin

            switch (rand)
            {
                case 0:
                    move = Movement.UP;
                    break;
                case 1:
                    move = Movement.RIGHT;
                    break;
                case 2:
                    move = Movement.DOWN;
                    break;
                case 3:
                    move = Movement.LEFT;
                    break;
                case 4:
                    move = Movement.NO_MOVEMENT;
                    break;
            }

            return move;
        }


    }
}
