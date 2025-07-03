using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    internal class Player : Character
    {
        public Player(string name, int health, int attackPower): base(name, health, attackPower){}
        public void AttackEnemy(Enemy enemy, Weapon weapon)
        {
            int totalDamage = AttackPower + weapon.Damage;

            if (!IsAlive)
            {
                Console.WriteLine($"{Name} is defeated and cannot attack.");
                return;
            }
            else {
                Console.WriteLine($"{Name}  attacks {enemy.Name} with {weapon.Name}");
                enemy.TakeDamage(totalDamage);  
            }
                
            

        }
    }
}
