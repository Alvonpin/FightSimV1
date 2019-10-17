using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimV1
{
    class Fighter
    {
        public List<string> species = new List<string>();
        protected string name;
        protected int hp;

        protected int minDamage;
        protected int maxDamage;

        protected int strength;
        protected int speed;
        protected int recovery;
      
        static private Random generator = new Random();

        public Fighter()
        {
            name = species[generator.Next(0, species.Count)]; //namn slumpas fram ur listan av arter
        }
        
        /* Används när en fighter attakerar en annan för att subtrahera skadan denna gör frön motståndarens hp
         * Damage tas fram i metoden Attack
         */ 

        private void Hurt(int damage)
        {
            hp = hp - damage;

            if (hp < 0)
            {
                hp = 0;
            }
        }

        /* Kallas i main när en fighter attackerar en annan
         * Metoden tar in en opponent för att ge en intuetiv beskrivning av vad som händer i main (a.Attack(b))
         * Metoden hurt kallas i attack för att subtrahera damage från hp
         */

        public void Attack(Fighter opponent)
        {
            opponent.Hurt(generator.Next(minDamage, maxDamage) + strength);
        }

        public bool Attempt()
        {
            if (10 >= generator.Next(speed))
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public void Parry (Fighter opponent)
        {

        }

        public bool IsAlive()
        {
            if (hp == 0)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public int GetHp()
        {
            return hp;
        }
    }
}
