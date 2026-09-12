using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleArena.Warrior
{
    public abstract class Warrior
    {
        private bool _IsAlive;

        public string Name { get; private set; }

        public string SpecialAttackNAme { get; set; }

        public int Health { get; private set; }

        public int AttackPower { get; private set; }

        public bool IsAlive
        {
            get
            {
                _IsAlive = Health > 0;
                return _IsAlive;
            }
            private set { _IsAlive = value; }
        }


        public Warrior(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }

        protected virtual void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
        }



        public virtual void DisplayStatus()
        {
            Console.WriteLine($"--== {Name} ==--");
            Console.WriteLine($"\t[*] Health: {Health}");
            Console.WriteLine($"\t[*] Attack Power: {AttackPower}");

        }

        public abstract void Attack(Warrior target);
    }
}