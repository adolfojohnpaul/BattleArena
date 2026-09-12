using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior Raymond = new Warrior("Raymond", 100, 30, "Sinuntok");
            Warrior Kirk = new Warrior("Kirk", 200, 15, "Sinipa");
            Warrior Athlon = new Warrior("Athlon", 150, 20, "Sinargo");

            Raymond.DisplayStatus();
            Kirk.DisplayStatus();
            Athlon.DisplayStatus();

            int round = 1;
            while (Raymond.IsAlive && Kirk.IsAlive && Athlon.IsAlive)
            {
                Console.WriteLine($"----------Round {round}-----------------");
                Raymond.Attack(Kirk);
                Kirk.Attack(Raymond);
                Athlon.Attack(Kirk);
                Console.WriteLine("---------------------------");
                round++;
            }
        }
    }
}