using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    internal class Enemy : Character
    {
       
        public Enemy(string name, int health, int attackPower):base(name,health,attackPower){}
        
        
        public void AttackPlayer(Player player)
        {
            if (!IsAlive)
            {
                Console.WriteLine($"{Name} is defeated and cannot attack.");
                return;
            }
            else {
                Console.WriteLine($"{Name} has attacked {player.Name}");
                player.TakeDamage(AttackPower);
            }
                
                
        }
    }
}
