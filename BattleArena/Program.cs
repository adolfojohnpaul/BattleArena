using battleArena.Warrior;
using BattleArena.warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace battleArena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Raymond = new Marksman("Raymond", 100, 30, 20);
            var Kirk = new Tank("Kirk", 200, 25, 15);
            var Athlon = new Fighter("Athlon", 100, 30, 20);


            Raymond.DisplayStatus();
            Kirk.DisplayStatus();

            while (Raymond.IsAlive && Kirk.IsAlive)
            {
                Console.WriteLine("\n\n======================================");
                Raymond.Attack(Kirk);
                Console.WriteLine("--------------------------------");
                Thread.Sleep(20000);
                Raymond.Attack(Kirk);
                Thread.Sleep(20000);

            }

            Console.ReadKey();
        }
    }
}