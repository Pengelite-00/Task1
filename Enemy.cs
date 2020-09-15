using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinGame
{
    public abstract class Enemy : Character
    {
        protected Random rnd;

        public Enemy (int x, int y, int enemyDamage, int hp, char symbol) : base(x,y,symbol)               //Constructor deriving variables from Character
        {
            this.damage = enemyDamage;
            this.HP = hp;
            this.maxHP = hp;
            
        }

        public override string ToString()
        {
            return this.GetType().Name + "at" + this.X + this.Y + this.damage;                      //ToString() overring method to display Enemy Stats
        }

    }
}
