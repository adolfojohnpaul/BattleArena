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
            int round = 1;
            var Raymond = new Raymond(100, 30);
            var Kirk = new Kirk(200, 15, 10);
            var Athlon = new Athlon(150, 30, 15);

            Raymond.DisplayStatus();
            Kirk.DisplayStatus();
            Athlon.DisplayStatus();

            while (Raymond.IsAlive && Kirk.IsAlive && Athlon.IsAlive)
            {
                Console.WriteLine("\n\n==========================================");
                Raymond.Attack(Kirk);
                Kirk.DisplayStatus();
                Console.WriteLine("----------------------------------------------");
                Athlon.Attack(Raymond);
                Athlon.DisplayStatus();
                Console.WriteLine("----------------------------------------------");
                round++;
            }

            Console.ReadKey();
        }
    }
}