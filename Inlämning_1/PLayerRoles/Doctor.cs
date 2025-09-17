using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1.PLayerRoles
{
    public class Doctor : PlayableClass
    {
        public string Name = "The man with no name";
        public int MaxHealth = 42;
        public int currentHealth = 42;
        public int GunAim = 5;
        public int Strenght = 5;
        public int StaringAmmo = 12;
        public int StartGold = 20;
        public int startingSupply = 3;


        public Doctor(string DocName)
        {
            Name = DocName;
        }

        public void ShowStats()
        {
            Console.WriteLine($"=== {Name} ===");
            Console.WriteLine($"Healt: {currentHealth}/{MaxHealth}");
            Console.WriteLine($"Gun aim: {GunAim}");
            Console.WriteLine($"Strenght: {Strenght}");
            Console.WriteLine($"Ammo Count: {StaringAmmo}");
            Console.WriteLine($"Gold: {StartGold}");
            Console.WriteLine($"=== {Name} ===");
        }

    }
}
