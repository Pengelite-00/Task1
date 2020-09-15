using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinGame
{
   public class Hero : Character
    {   //Question 2.6
        public Hero (int x, int y, int hp, int damage) : base(x,y,'H')                 //Constructor deriving variables from Character class
        {
            this.HP = hp;
            this.maxHP = hp;
            this.damage = 2;
        }

        public override Movement ReturnMove(Movement move)                                      //Movement Method
        {
            bool canMove = false;
            switch(move)                                         //Switch case to determine if Hero can move in intended direction
            {
                case Movement.UP:
                    if (characterVision[0].GetType().Name.Equals(nameof(EmptyTile))) { canMove = true; }
                    break;
                case Movement.RIGHT:
                    if (characterVision[1].GetType().Name.Equals(nameof(EmptyTile))) { canMove = true; }
                    break;
                case Movement.DOWN:
                    if (characterVision[2].GetType().Name.Equals(nameof(EmptyTile))) { canMove = true; }
                    break;
                case Movement.LEFT:
                    if (characterVision[3].GetType().Name.Equals(nameof(EmptyTile))) { canMove = true; }
                    break;
            }

            if (canMove)
            {
                return move;
            }

            else
            {
                return Movement.NO_MOVEMENT;
            }


        }

        public override string ToString()
        {
            return "";
        }

    }
}
