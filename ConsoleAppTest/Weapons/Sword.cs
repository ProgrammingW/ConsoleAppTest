using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    internal class Sword : Weapon
    {
        public bool isEnchanted;
        public Sword(string name, string type, int damage, float weight, int staminatoattack) : base(name, type, damage, weight, staminatoattack)
        {
            isEnchanted = false;
        }
        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks with {Damage} damage!");
        }
    }
}