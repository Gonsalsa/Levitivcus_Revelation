using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1.PLayerRoles
{
    public class Pilgrim : PlayableClass
    {
        public string Name = "The penitent one";
        public int MaxHealth = 50;
        public int currentHealth = 50;
        public int GunAim = 2;
        public int Strenght = 10;
        public int StaringAmmo = 0;
        public int StartGold = 5;
        public int startingSupply = 1;


        public Pilgrim(string PilgrimName)
        {
            Name = PilgrimName;
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
