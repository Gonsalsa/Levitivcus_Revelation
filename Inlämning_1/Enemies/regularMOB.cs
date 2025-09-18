using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1.Enemies
{
    public class regularMOB : BaseEnemies
    {
        Random r = new Random();

        public string[] mobNames = { "Infernal Hound", "Dustwalker", "Highwayman", "Evangelist of Revelation", "Corrupted Pilgrim" };

        public regularMOB()
        {

            int randomName = r.Next(0, mobNames.Length);

            Name = mobNames[randomName];
            MaxHealt = r.Next(5, 16);
            Strenght = r.Next(4, 10);
            goldReward = r.Next(3, 6);
        }
    }
}

