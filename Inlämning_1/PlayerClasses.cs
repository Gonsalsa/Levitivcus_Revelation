
using System.Security.Cryptography.X509Certificates;

namespace Inlämning_1
{
    public class PlayerClasses
    {
        public class Gunslinger 
        {
            Random random = new Random();

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

            public void Rest()
            {
                if (startingSupply <= 0)
                {
                    Console.WriteLine("You have no supplies, you can not rest right now.");
                    return;
                }

                currentHealth = currentHealth + (MaxHealth / 4);
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

        public class Doctor
        {
            Random random = new Random();

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

        public class Pilgrim
        {
            Random random = new Random();

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



}