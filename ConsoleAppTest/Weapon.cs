using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    public class Weapon
    {   
        public string Name { get; set; }
        public string Type { get; set; }
        public int Damage { get; set; }

        public float Weight { get; set; }
        public int StaminaToAttack { get; set; }

        public bool isHeavy
        {
            get
            {
                return Weight > 10.0f; // Example condition for heavy weapon
            }
        }

        public Weapon(string name, string type, int damage, float weight, int staminatoattack)
        {
            Name = name;
            Type = type;
            Damage = damage;
            Weight = weight;
            StaminaToAttack = staminatoattack;
        }
        public void Attack()
        {
            Console.WriteLine($"{Name} attacks with {Damage} damage!");
        }

        public void Inspect()
        {
            Console.WriteLine($"Weapon: {Name}, Type: {Type}, Damage: {Damage}, Weight: {Weight}kg");
            if (isHeavy)
            {
                Console.WriteLine("This weapon is heavy.");
            }
            else
            {
                Console.WriteLine("This weapon is not heavy.");
            }
        }
        public void Upgrade(int additionalDamage)
        {
            Damage += additionalDamage;
            Console.WriteLine($"{Name} upgraded! New damage: {Damage}");
        }

    }
}
