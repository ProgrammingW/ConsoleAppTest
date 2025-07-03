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

        public int Stamina { get; set; } = 100; // Default stamina value

        public Character(string name, int health, int attackPower, int stamina)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Stamina = stamina;
        }

        public virtual void TakeDamage(int amount)
        {
            if (!IsAlive)
            {
                Console.WriteLine($"{Name} is already defeated and cannot take more damage.");
                return;
            }

            Health -= amount;
            if (Health <= 0) 
            {
                Console.WriteLine($"{Name} has been defeated!");
                Health = 0; // Ensure health does not go below zero

            }
            Console.WriteLine($"{Name} takes {amount} damage! Remaining health: {Health}");

            

        }
        public virtual bool hasStamina(int StaminaAttackCost)
        {
            if (Stamina >= StaminaAttackCost)
            {
                Console.WriteLine($"{Name} has enough stamina. Remaining stamina: {Stamina}");
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual void Inspect()
        {
            Console.WriteLine($"{Name} — Health: {Health} — Attack: {AttackPower} — Status: {(IsAlive ? "Alive" : "Defeated")}");
        }
    }
}

