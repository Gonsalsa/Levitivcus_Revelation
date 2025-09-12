
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
            public int GunAim = 10;
            public int Strenght = 3;
            public int StaringAmmo = 30;
            public int SinLevel = 10;
            public int StartGold = 20;


            public Gunslinger(string gunslingerName)
            {
                Name = gunslingerName;
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
            public int GunAim = 5;
            public int Strenght = 5;
            public int StaringAmmo = 12;
            public int SinLevel = 5;
            public int StartGold = 20;


            public Doctor(string DocName)
            {
                Name = DocName;
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
            public int GunAim = 2;
            public int Strenght = 10;
            public int StaringAmmo = 0;
            public int SinLevel = 1;
            public int StartGold = 5;



            public Pilgrim(string PilgrimName)
            {
                Name = PilgrimName;
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