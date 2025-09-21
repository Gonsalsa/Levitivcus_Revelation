using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inlämning_1.PLayerRoles;

namespace Inlämning_1
{
    public class Shop
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
                        Console.WriteLine("Pick one from the choices you have");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }
        }



        public static void EnterShop(PlayableClass player)
        {
            Console.Write("You encounter a strange wagon at a crossroad, and outside of it sitts a tall ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Man");
            Console.ResetColor();
            Console.Write(". His head coverd with a gray hood.");
            Console.WriteLine("He feels familiar yet like a stranger at the same time.");
            Console.WriteLine("And in his burning yelllow eyes you can see something either divine or infernal hiding behind them.");
            Console.ReadKey();
            Console.Clear();

            bool isShopping = true;
            while (isShopping)
            {
                Console.Clear();
                Console.ResetColor();
                Console.WriteLine($"Your total gold: {player.StartGold}");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Welcome travler, what may i offer you today?");
                Console.WriteLine("[1.] 5x bullets. 10 gold");
                Console.WriteLine("[2.] 1x Supply pack. 20 gold");
                Console.WriteLine("[3.] Enhanced aim for the cost of your health. 50 gold");
                Console.WriteLine("[4.] Enhanced strenght at the cost of your healh. 50 gold");
                Console.WriteLine("[5.] Atonement. 150 gold");
                Console.WriteLine("[6.] Leave the shop.");

                int shopChoice = IsNumeric(6);

                switch (shopChoice)
                {
                    case 1:
                        if (player.StartGold >= 10)
                        {
                            Console.WriteLine("Very well, here is your bullets.");
                            player.bulletCount = player.bulletCount + 5;
                            player.StartGold = player.StartGold - 10;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough gold for that, my friend.");
                            Console.ReadKey();

                        }
                        break;

                    case 2:
                        if (player.StartGold >= 20)
                        {
                            Console.WriteLine("Very well, here is your supplies");
                            player.startingSupply++;
                            player.StartGold = player.StartGold - 20;
                            Console.ReadKey();

                        }
                        else
                        {
                            Console.WriteLine("You don't have enough gold for that, my friend.");
                            Console.ReadKey();

                        }
                        break;

                    case 3:
                        if (player.StartGold >= 50 && player.MaxHealth > 0)
                        {
                            Console.WriteLine("Very well, you picked power over blood.");
                            player.GunAim = player.GunAim + 2;
                            player.MaxHealth = player.MaxHealth - 5;
                            player.StartGold = player.StartGold - 50;
                            Console.ReadKey();

                        }
                        else
                        {
                            Console.WriteLine("I can't let you do that with what you have.");
                            Console.ReadKey();

                        }
                        break;

                    case 4:
                        if (player.StartGold >= 50 && player.MaxHealth > 0)
                        {
                            Console.WriteLine("Very well, you picked power over blood.");
                            player.Strenght = player.Strenght + 2;
                            player.MaxHealth = player.MaxHealth - 5;
                            player.StartGold = player.StartGold - 50;
                            Console.ReadKey();


                        }
                        else
                        {
                            Console.WriteLine("I can't let you do that with what you have.");
                            Console.ReadKey();


                        }
                        break;

                    case 5:
                        if (player.hasRedemption == false && player.StartGold > 150)
                        {
                            Console.WriteLine("Very well, then sins that still keeps you in this world won't bother you no more.");
                            player.hasRedemption = true;
                            player.StartGold = player.StartGold - 150;
                            Console.ReadKey();

                        }
                        else
                        {
                            Console.WriteLine("Thats nothing of your concern at them moment.");
                            Console.ReadKey();

                        }
                        break;

                    case 6:
                        isShopping = false;
                        break;

                }

            }

            Console.Clear();
            Console.WriteLine("Our ways part for now, but they will cross again.");
            Console.ReadKey();
            Console.ResetColor();

        }



    }
}
