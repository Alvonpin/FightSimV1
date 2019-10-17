using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimV1
{
    class Amphibian: Fighter
    {
        private int poison;

        public Amphibian()
        {
            species = new List<string> { "Frog", "Axolotl", "Salamander", "Toad" };

            hp = 25;

            minDamage = 2;
            maxDamage = 15;

            strength = 0;
            speed = 11;
            recovery = 10;
        }
    }
}
