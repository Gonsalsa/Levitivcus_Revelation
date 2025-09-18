using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1.PLayerRoles
{
    public class Gunslinger : PlayableClass
    {
        public string Name = "The man with no name";
        public int MaxHealth = 25;
        public int currentHealth = 25;
        public int GunAim = 10;
        public int Strenght = 3;
        public int StaringAmmo = 18;
        public int StartGold = 20;
        public int startingSupply = 3;


        public Gunslinger(string gunslingerName)
        {
            Name = gunslingerName;
        }

        public void ShowStats()
        {
            Console.WriteLine($"=== {Name} ===");
            Console.WriteLine($"Health: {currentHealth}/{MaxHealth}");
            Console.WriteLine($"Gun aim: {GunAim}");
            Console.WriteLine($"Strenght: {Strenght}");
            Console.WriteLine($"Ammo Count: {StaringAmmo}");
            Console.WriteLine($"Gold: {StartGold}");
            Console.WriteLine($"=== {Name} ===");
        }
    }
}
