using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    internal class Player : Character
    {
        public Player(string name, int health, int attackPower, int stamina): base(name, health, attackPower, stamina){}
        public void AttackEnemy(Enemy enemy, Weapon weapon, int specialDamage=0, bool specialAttack=false)
        {

            int totalDamage = 0;
            if (specialDamage > 0)
            {
                Console.WriteLine($"{Name} uses a special attack with {weapon.Name} for {specialDamage} extra damage!");
                totalDamage = specialDamage + weapon.Damage;
            }
            else
            {
                totalDamage = AttackPower + weapon.Damage;
            }

            if (!IsAlive)
            {
                Console.WriteLine($"{Name} is defeated and cannot attack.");
                return;
            }
            else
            {
                if (hasStamina(weapon.StaminaToAttack))
                {

                    Console.WriteLine($"{Name}  attacks {enemy.Name} with {weapon.Name} using {Stamina} Stamina");
                    if (!specialAttack) {
                        Stamina -= weapon.StaminaToAttack;
                    }
                    
                    enemy.TakeDamage(totalDamage);
                }
                else
                {
                    Console.WriteLine($"{Name} needs {weapon.StaminaToAttack} stamina to attack with {weapon.Name}. Current stamina: {Stamina}");
                    return;
                }
            }
        }
        public void SpecialAttack(Enemy enemy,Weapon weapon, int StaminaSpecialAttack)
        {
            if (Stamina < StaminaSpecialAttack) // Example condition for special attack
            {
                Console.WriteLine($"{Name} does not have enough stamina for a special attack.");
                return;
            }
            else{
                int specialDamage = AttackPower * 2; // Example special attack damage calculation
                Stamina -= StaminaSpecialAttack; // Deduct stamina for special attack
                AttackEnemy(enemy, weapon,specialDamage,true);
                
            }
                
        }
    }
}
