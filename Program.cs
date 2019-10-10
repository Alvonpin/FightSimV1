using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name your fighter");
            Fighter Player = new Fighter(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Name your opponent");
            Fighter Opponent = new Fighter(Console.ReadLine());
            Console.Clear();

            do
            {
                Player.Hurt(Player.Attack());
                Opponent.Hurt(Opponent.Attack());

                Console.WriteLine(Player.GetHp());
                Console.WriteLine(Opponent.GetHp());

                Console.ReadLine();

            }
            while (Player.IsAlive() == true && Opponent.IsAlive() == true);

            if (Player.IsAlive() == true)
            {
                Console.WriteLine(Player.name + " won");
            }

            else
            {
                Console.WriteLine(Opponent.name + " won");
            }

            Console.ReadLine();




        }
    }
}
