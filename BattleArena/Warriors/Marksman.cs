using battleArena.Warrior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena.warriors
{
    public class Marksman : Warrior
    {
        public int ArrowDamage { get; private set; }

        public Marksman(string name, int health, int attackPower, int arrowDamage)
            : base(name, health, attackPower)
        {
            ArrowDamage = arrowDamage;

        }

        public override void Attack(Warrior target)
        {
            var totalDamage = target.AttackPower + ArrowDamage;
            TakeDamage(totalDamage);
            Console.WriteLine($"\t->{Name}: Sasampalin kita {target.Name}!");
            Console.WriteLine($"\t->{target.Name}: Aray ko!");
            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}Buhay pako {target.Name}");
            Console.WriteLine($"\t-------------{target.Name}--------");
            Console.WriteLine($"\t *damage taken {totalDamage}");
            Console.WriteLine($"\t *health left {target.Health}");
            Console.WriteLine($"\t------------------------------");
        }
    }
}