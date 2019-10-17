using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimV1
{
    class Mammal: Fighter
    {
    public Mammal()
        {
            species = new List<string> { "Moose", "Bear", "Hippo", "Tiger" };

            hp = 100;

            minDamage = 10;
            maxDamage = 15;

            strength = 10;
            speed = 12;
            recovery = 0;
        }
    }
}
