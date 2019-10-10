using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimV1
{
    class Fighter
    {
        public string name;
        private int hp;
        static private Random generator = new Random();

        public Fighter(string input)
        {
            name = input;
            hp = 100;
        }

        public int Attack()
        {
            int damage = generator.Next(0, 50);

            return damage;
        }

        public void Hurt(int damage)
        {
            hp = hp - damage;

            if (hp < 0)
            {
                hp = 0;
            }
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
