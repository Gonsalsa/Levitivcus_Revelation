using Inlämning_1.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1.PLayerRoles
{
    public class PlayableClass
    {
        Random random = new Random();

        public string Name = "The man with no name";
        public string className;
        public int MaxHealth;
        public int currentHealth;
        public int GunAim;
        public int Strenght;
        public int bulletCount;
        public int StartGold;
        public int startingSupply;
        public bool hasRedemption = false;


        public void Rest()
        {
            if (startingSupply <= 0)
            {
                Console.WriteLine("You have no supplies, you can not rest right now.");
                return;
            }

            currentHealth = currentHealth + (MaxHealth / 3);
            startingSupply = startingSupply - 1;
            Console.WriteLine("You have patched up some of your wounds and got some sleep, you feel better for now.");

            if (currentHealth > MaxHealth)
            {
                currentHealth = MaxHealth;
            }

        }
        public void Shoot(BaseEnemies enemy)
        {
            if (bulletCount <= 0)
            {
                Console.WriteLine("You have no bullets.");
                return;
            }

            int CriticalHit = random.Next(1, 11);

            int baseDmg = 10 + GunAim;

            if (CriticalHit == 10)
            {
                Console.WriteLine("The attack was well aimed");
                baseDmg = baseDmg * 2;
            }

            int enemyDmgTaken = enemy.currentHealth - baseDmg;
            enemy.currentHealth = enemyDmgTaken;
            Console.WriteLine($"You did {baseDmg} damage to the enemy");
            /*if (enemy.currentHealth <= 0)
            {
                Console.WriteLine("You have sent the enemy back to the hell they came from. They are now dead.");
            }*/
            bulletCount = bulletCount - 1;
        }
        public void Stab(BaseEnemies enemy)
        {
            int CriticalHit = random.Next(1, 11);

            int baseDmg = 10 + Strenght;

            if (CriticalHit == 10)
            {
                Console.WriteLine("The attack was well aimed");
                baseDmg = baseDmg * 2;
            }

            int enemyDmgTaken = enemy.currentHealth - baseDmg;
            enemy.currentHealth = enemyDmgTaken;
            Console.WriteLine($"You did {baseDmg} damage to the enemy");
            //if (enemy.currentHealth <= 0)
            //{
            //    Console.WriteLine("You have sent the enemy back to the hell they came from. They are now dead.");
            //}
        }
        public void ShowStats()
        {
            Console.WriteLine($"=== {Name} ===");
            Console.WriteLine($"Class: {className}");
            Console.WriteLine($"Health: {currentHealth}/{MaxHealth}");
            Console.WriteLine($"Gun aim: {GunAim}");
            Console.WriteLine($"Strenght: {Strenght}");
            Console.WriteLine($"Ammo Count: {bulletCount}");
            Console.WriteLine($"Supplies: {startingSupply}");
            Console.WriteLine($"Gold: {StartGold}");
            Console.WriteLine($"=== {Name} ===");
        }
        public void Gunslinger()
        {
            className = "Gunslinger";
            MaxHealth = 25;
            currentHealth = 25;
            GunAim = 10;
            Strenght = 3;
            bulletCount = 18;
            StartGold = 20;
            startingSupply = 3;

        }

        public void Pilgrim()
        {
            className = "Pilgrim";
            MaxHealth = 50;
            currentHealth = 50;
            GunAim = 2;
            Strenght = 10;
            bulletCount = 0;
            StartGold = 5;
            startingSupply = 1;

        }

        public void Doctor()
        {
            className = "Doctor";
            MaxHealth = 42;
            currentHealth = 42;
            GunAim = 5;
            Strenght = 5;
            bulletCount = 6;
            StartGold = 10;
            startingSupply = 3;
        }

    }
}


