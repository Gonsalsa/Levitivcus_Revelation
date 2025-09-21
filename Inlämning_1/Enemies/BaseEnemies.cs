using Inlämning_1.PLayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1.Enemies
{
    public class BaseEnemies
    {
        Random r = new Random();

        public string Name = "Corrupted Pilgrim";
        public int maxHealth = 11;
        public int currentHealth;
        public int Strenght = 4;
        public int goldReward = 3;

        public void Attack(PlayableClass player)
        {
            int chanceToCrit = r.Next(0, 11);

            int baseDmg = Strenght;

            if (chanceToCrit == 9)
            {
                baseDmg = baseDmg * 2;
            }

            int DmgDealt = player.currentHealth - baseDmg;
            player.currentHealth = player.currentHealth - DmgDealt;
            Console.WriteLine($"The enemy did {DmgDealt} damage");
        }

        public void showStats()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"=== {Name} ===");
            Console.WriteLine($"Hp: {currentHealth}/{maxHealth}");
            Console.ResetColor();
        }


    }

}
