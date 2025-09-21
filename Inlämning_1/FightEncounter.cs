using Inlämning_1.Enemies;
using Inlämning_1.PLayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1
{
    public class FightEncounter
    {

        static int IsNumeric(int maxChoices)
        {
            int number;

            while (true)
            {
                Console.WriteLine("What do you choose? ");
                string gonnaCheck = Console.ReadLine();

                if (int.TryParse(gonnaCheck, out number))
                {
                    if (0 < number && number <= maxChoices)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("What do you want to do?");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }
        }

        static Random r = new Random();

        public static void Fight(PlayableClass player)
        {

            int chanceOfElite = r.Next(0, 11);



            Console.Clear();

            var enemy = new BaseEnemies();

            if (chanceOfElite == 4)
            {
                enemy = new EliteMOB();
            }
            else
            {
                enemy = new regularMOB();
            }
            Console.WriteLine($"You have encounterd what looks like a {enemy.Name}!");
            enemy.currentHealth = enemy.maxHealth;
            Console.ReadKey();
            Console.Clear();

            bool isFighting = true;
            while (isFighting)
            {



                player.ShowStats();
                enemy.showStats();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("[1] Shoot it");
                Console.WriteLine("[2] Stab it");
                Console.WriteLine("[3] Try to get away from it");

                int choice = IsNumeric(3);

                switch (choice)
                {
                    case 1:
                        player.Shoot(enemy);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        player.Stab(enemy);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        int chanceToFlee = r.Next(1, 6);
                        if (chanceToFlee == 2)
                        {
                            Console.WriteLine("You managed to escape");
                            isFighting = false;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("You tried to escape but to no succsess...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;


                }
                if (enemy.currentHealth <= 0)
                {
                    player.StartGold = player.StartGold + enemy.goldReward;
                    Console.WriteLine($"You got {enemy.goldReward} gold");
                    Console.WriteLine($"The {enemy.Name} has died.");
                    isFighting = false;
                    break;

                }
                enemy.Attack(player);
                Console.ReadKey();
                Console.Clear();
                if (player.currentHealth <= 0)
                {
                    isFighting = false;
                    break;
                }
            }






        }
    }
}
