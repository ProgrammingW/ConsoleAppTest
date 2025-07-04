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
            

            if (!IsAlive)
            {
                Console.WriteLine($"{Name} is defeated and cannot attack.");
                return;
            }
            if (!enemy.IsAlive) {
                Console.WriteLine($"{enemy.Name} is defeated. Are you going to kill him again {Name}?");
                return;
            }

            totalDamage = (specialDamage>0) ? specialDamage + weapon.Damage : AttackPower + weapon.Damage;

            if (!specialAttack) {
                if (!hasStamina(weapon.StaminaToAttack)) {
                    Console.WriteLine($"{Name} needs {weapon.StaminaToAttack} stamina to attack with {weapon.Name}. Current stamina: {Stamina}");
                    return;
                }
                Stamina -= weapon.StaminaToAttack;
            }

            Console.WriteLine($"{Name}  attacks {enemy.Name} with {weapon.Name} using {Stamina} Stamina");
            enemy.TakeDamage(totalDamage);
           
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

                Console.WriteLine($"{Name} uses a special attack with {weapon.Name} for {specialDamage} extra damage!");
                AttackEnemy(enemy, weapon,specialDamage,true);
                

            }
                
        }
    }
}
