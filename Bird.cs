using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimV1
{
    class Bird: Fighter
    {
        public Bird()
        {
            species = new List<string> { "Osprey", "Kite", "Goose", "Swan" };

            hp = 50;

            minDamage = 5;
            maxDamage = 10;

            strength = 5;
            speed = 20;
            recovery = 0;
        }
    }
}
