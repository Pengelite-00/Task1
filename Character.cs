using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinGame
{
    public abstract class Character : Tile
    {
        protected int HP;
        protected int maxHP;
        protected int damage;                          //Declarations
        public Tile[] characterVision;


        public Character(int x, int y, char symbol) : base(x, y)                     //Constructor Deriving variables from Tile
        {
            characterVision = new Tile[4];
        }

        public int healthPoints                                  //Gets and sets for above variables
        {
            get { return HP; }
            set { HP = value; }
        }

        public int maxHealth
        {
            get { return maxHP; }
            set { maxHP = value; }
        }

        public int dmg
        {
            get { return damage; }
            set { damage = value; }
        }

        public Tile[] CharVision
        {
            get { return characterVision; }
            set { characterVision = value; }
        }


        public enum Movement { NO_MOVEMENT, UP, DOWN, LEFT, RIGHT}         


        public virtual void Attack(Character hostile)                        //placeholder
        {
            
        }


        public bool isDead()                      //Method to check if character is dead
        {
            if(this.HP <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }


        public virtual bool CheckRange(Character hostile)           //Method to check if character is within range
        {
            int range = 1;
            
            if (DistanceTo(hostile) == range)
            {
                return true;
            }
             
            else
            {
                return false;
            }

        }


        private int DistanceTo(Character hostile)              //Method to determine distance between 2 characters
        {
            int distX = Math.Abs(hostile.X - this.X);
            int distY = Math.Abs(hostile.Y - this.Y);

            return distX + distY;
        }


        public void Move(Movement move)                   //Switch Case for movement on a 2D plain
        {
            switch(move)
            {
                case Movement.UP:
                    this.y++;
                    break;
                case Movement.DOWN:
                    this.y--;
                    break;
                case Movement.LEFT:
                    this.x++;
                    break;
                case Movement.RIGHT:
                    this.x--;
                    break;
            }
        }


        public abstract Movement ReturnMove(Movement move = 0);

        public abstract override string ToString();


    }
}
