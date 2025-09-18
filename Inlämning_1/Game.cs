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


        static void Main(string[] args)
        {
            Console.WriteLine("1886, Somewhere on the wast steps of the west.");
            Console.WriteLine("The Preacher Leviticus Jones spoke of the coming endtimes and was condeemed mad.");
            Console.WriteLine("He founded the new settlement named Antioch and began preperations for the time to come.");
            Console.WriteLine("Now something has happend. Hell is let loose and the west has turned wild.");
            Console.WriteLine("Many like you have started the journey towards Antioch to find a sanctuary in this dying world and find out about");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n \n ----- LEVITICUS REVELATION -----\n \n");


            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();

            Console.WriteLine("What class do you wanna play?");
            Console.WriteLine("[1] The gunslinger, a character proficient with their weapon but can't take much hits.");
            Console.WriteLine("[2] The Doctor, a robust character who makes up in health for what they lack in combat abillites.");
            Console.WriteLine("[3] The pilgrim, a character with much strenght trying to reedem his sins. (HARD MODE) \n");

            Console.Write("Enter 1, 2 or 3: ");
            int classChoice = IsNumeric(3);

            switch (classChoice)
            {
                case 1:
                    Console.Write("Enter your name: ");
                    string gunslingerName = Console.ReadLine();
                    Gunslinger gunslingerPlayer = new Gunslinger(gunslingerName);
                    gunslingerPlayer.ShowStats();
                    break;

                case 2:
                    Console.Write("Enter your name: ");
                    string doctorName = Console.ReadLine();
                    Doctor doctorPlayer = new Doctor(doctorName);
                    doctorPlayer.ShowStats();
                    break;

                case 3:
                    Console.Write("Enter your name: ");
                    string pilgrimName = Console.ReadLine();
                    Pilgrim pilgrimPlayer = new Pilgrim(pilgrimName);
                    pilgrimPlayer.ShowStats();
                    break;

                default:
                    Console.WriteLine("Something is wrong");
                    break;

            }

            bool running = true;
            while (running)
            {

            }


        }
    }
}
