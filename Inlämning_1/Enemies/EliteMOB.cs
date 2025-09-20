using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1.Enemies
{
    public class EliteMOB : BaseEnemies
    {
        Random r = new Random();

        public string[] eliteMobs = { "Judge of the end times", "Fallen angel", "Cursed Bison" };

       public EliteMOB()
        {
            int randomName = r.Next(0, eliteMobs.Length);

            Name = eliteMobs[randomName];
            maxHealth = r.Next(5, 26);
            Strenght = r.Next(4, 15);
            goldReward = r.Next(3, 10);
        }

    }
}
