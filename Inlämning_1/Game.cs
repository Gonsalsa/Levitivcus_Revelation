using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using Inlämning_1.PLayerRoles;

namespace Inlämning_1
{
    internal class Game
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

        PlayableClass mainCharacter = new PlayableClass();

        static void Main(string[] args)
        {
            Console.WriteLine("1886, Somewhere on the wast steps of the west.");
            Console.WriteLine("The Preacher Leviticus Jones spoke of the coming endtimes and was condeemed mad.");
            Console.WriteLine("He founded the new settlement named Antioch and began preperations for the time to come.");
            Console.WriteLine("Now something has happend. Hell is let loose and the west has turned wild.");
            Console.WriteLine("Many like you have started the journey towards Antioch to find a sanctuary in this dying world and find out about");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n \n ----- LEVITICUS REVELATION -----\n \n");
            Console.WriteLine("Only those who are without sin may find the way");

            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();



            Console.WriteLine("What class do you wanna play?");
            Console.WriteLine("[1] The gunslinger, a character proficient with their weapon but can't take much hits.");
            Console.WriteLine("[2] The Doctor, a robust character who makes up in health for what they lack in combat abillites.");
            Console.WriteLine("[3] The pilgrim, a character with much strenght trying to reedem his sins. (HARD MODE) \n");

            Console.Write("Enter 1, 2 or 3: ");
            int classChoice = IsNumeric(3);

            PlayableClass Player = new PlayableClass();


            switch (classChoice)
            {
                case 1:
                    Console.Write("Enter your name: ");
                    string gunslingerName = Console.ReadLine();
                    Player.Name = gunslingerName;
                    Player.Gunslinger();
                    Player.ShowStats();
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Write("Enter your name: ");
                    string doctorName = Console.ReadLine();
                    Player.Name = doctorName;
                    Player.Doctor();
                    Player.ShowStats();
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Write("Enter your name: ");
                    string pilgrimName = Console.ReadLine();
                    Player.Name = pilgrimName;
                    Player.Pilgrim();
                    Player.ShowStats();
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Something is wrong");
                    break;

            }

            int numberOfTurns = 1;

            bool running = true;
            while (running)
            {
                Console.Clear();

                if (Player.hasRedemption == true)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("You feel your soul become lighter and the soft music of heaven fill your ears");
                    Console.WriteLine("You haven found your peace in the world.");
                    Console.WriteLine("You have finished the game, thanks for playing!");
                    Console.ReadKey();
                    running = false;
                    break;
                }


                if (Player.currentHealth <= 0)
                {
                    Console.WriteLine("Your eyes start to feel heavy and you begin to feel weaker and weaker.");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("YOU HAVE DIED");
                    Console.ResetColor();
                    running = false;
                    Console.ReadKey();
                    break;
                }

                LandscapeSettings.landscapeGenerator();
                Console.ReadKey();

                FightEncounter.Fight(Player);
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();



                bool resting = true;
                while (resting)
                {

                    Console.WriteLine("Do you want to rest and regain som Hp?");
                    Console.WriteLine("[1.] Yes");
                    Console.WriteLine("[2.] No");

                    int restChoice = IsNumeric(2);
                    switch (restChoice)
                    {
                        case 1:
                            if (Player.startingSupply > 0)
                            {
                                int healthRegen = Player.currentHealth + (Player.MaxHealth / 3);
                                if (healthRegen + Player.currentHealth > Player.MaxHealth)
                                {
                                    Player.currentHealth = Player.MaxHealth;
                                }
                                else
                                {
                                    Player.currentHealth += healthRegen;                                
                                }
                                    Console.WriteLine($"You have recoverd some Hp.");
                                    Player.startingSupply--;
                                    resting = false;
                                    Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("You have no supplies. Git Gud");
                                resting = false;
                                Console.ReadKey();
                            }
                            break;

                        case 2:
                            resting = false;
                            break;
                    }


                }

                if (numberOfTurns % 5 == 0)
                {
                    Shop.EnterShop(Player);
                }

                numberOfTurns++;
            }


        }
    }
}
