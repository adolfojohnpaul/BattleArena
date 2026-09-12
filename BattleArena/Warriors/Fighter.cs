using battleArena.Warrior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena.warriors
{
    public class Fighter : Warrior
    {

        public int SwordDamage { get; private set; }

        public Fighter(string name, int health, int attackPower, int swordDamage)
            : base(name, health, attackPower)
        {
            SwordDamage = swordDamage;
        }

        public override void Attack(Warrior target)
        {
            var totalDamage = target.AttackPower + SwordDamage;
            TakeDamage(totalDamage);
            Console.WriteLine($"\t->{Name}: tutuhugin kita {target.Name}!");
            Console.WriteLine($"\t->{target.Name}: aray!");
            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}buhay pako {target.Name}");
            Console.WriteLine($"\t-------------{target.Name}--------");
            Console.WriteLine($"\t *damage taken {totalDamage}");
            Console.WriteLine($"\t *health left {target.Health}");
            Console.WriteLine($"\t------------------------------");
        }
    }
}