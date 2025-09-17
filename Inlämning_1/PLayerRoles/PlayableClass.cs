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
        public int MaxHealth;
        public int currentHealth;
        public int GunAim;
        public int Strenght;
        public int StaringAmmo;
        public int StartGold;
        public int startingSupply;


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
        public void Shoot(MobType mobType)
        {
            int CriticalHit = random.Next(1, 11);

            int baseDmg = 10 + GunAim;

            if (CriticalHit == 10)
            {
                Console.WriteLine("The attack was well aimed");
                baseDmg = baseDmg * 2;
            }

            int enemyDmgTaken = mobType.MaxHealt - baseDmg;
            if (mobType.MaxHealt <= 0)
            {
                Console.WriteLine("You have sent the enemy back to the hell they came from. They are now dead.");
            }

        }
        public void Stab(MobType mobType)
        {
            int CriticalHit = random.Next(1, 11);

            int baseDmg = 10 + Strenght;

            if (CriticalHit == 10)
            {
                Console.WriteLine("The attack was well aimed");
                baseDmg = baseDmg * 2;
            }

            int enemyDmgTaken = mobType.MaxHealt - baseDmg;
            if (mobType.MaxHealt <= 0)
            {
                Console.WriteLine("You have sent the enemy back to the hell they came from. They are now dead.");
            }
        }
        
    }
}


