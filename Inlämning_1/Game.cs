namespace Inlämning_1
{

   

    internal class Game
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1886, Somewhere on the wast steps of the west.");
            Console.WriteLine("The Preacher Leviticus Jones spoke of the coming endtimes and was condeemed mad.");
            Console.WriteLine("He founded the new settlement named Antioch and began preperations for the time to come.");
            Console.WriteLine("Now something has happend. Hell is let loose and the west has turned wild.");
            Console.WriteLine("Many like you have started the journey towards Antioch to find a sanctuary in this dying world and find out about");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("LEVITICUS REVELATION\n \n");
            Console.ResetColor();

            Console.WriteLine("What class do you wanna play?");
            Console.WriteLine("[1] The gunslinger, a character proficient with their weapon but can't take much hits.");
            Console.WriteLine("[2] The Doctor, a robust character who makes up in health for what they lack in combat abillites.");
            Console.WriteLine("[3] The pilgrim, a character with much strenght trying to reedem his sins. \n");

            Console.Write("Enter 1, 2 or 3: ");
            string classChoice = Console.ReadLine();


        }
    }
}
