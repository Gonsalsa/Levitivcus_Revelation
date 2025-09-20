using Inlämning_1.Enemies;
using Inlämning_1.PLayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1
{
    public class FightEncounter
    {
        Random r = new Random();

        public void Fight(BaseEnemies newEnemy, PlayableClass player)
        {
            int chanceOfElite = r.Next(0, 11);

            if (chanceOfElite == 4)
            {
                EliteMOB eliteEnemy = new EliteMOB();
            } else
            {
                regularMOB regularEnemy = new regularMOB();
            }

            bool ongoingFight = true;
            while (ongoingFight)
            {

            }


        }


    }
}
