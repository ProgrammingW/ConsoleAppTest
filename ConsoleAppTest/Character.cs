using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    internal class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public bool IsAlive => Health > 0;

        public Character(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }

        public virtual void TakeDamage(int amount)
        {
            if (!IsAlive)
            {
                Console.WriteLine($"{Name} is already defeated and cannot take more damage.");
                return;
            }

            Health -= amount;
            Console.WriteLine($"{Name} takes {amount} damage! Remaining health: {Health}");

            if (Health <= 0)
            {
                Console.WriteLine($"{Name} has been defeated!");
                Health = 0; // Ensure health does not go below zero

            }

        }

        public virtual void Inspect()
        {
            Console.WriteLine($"{Name} — Health: {Health} — Attack: {AttackPower} — Status: {(IsAlive ? "Alive" : "Defeated")}");
        }
    }
}

