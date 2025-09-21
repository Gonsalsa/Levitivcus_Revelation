using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1
{
    public class LandscapeSettings
    {



        public static void landscapeGenerator()
        {
            Random r = new Random();

            string[] Landscapes =
             {
            "You have arrived to the shores of a quiet lake, gazeing over its beuty, when you hear something.", //generatedLandscape = 0
            "you find what looks like a newly abandond camping spot. You feel like someone is watching you.", // generatedLandscape = 1
            "You are on the outskirts of an old mining town, you wonder if it's glory days is long gone whne you see something move in the corner of your eyes.", //generatedLandscape = 2
            "You find yourself on the edge of a deep canyon, looking in the darkness of its depths when suddenly see something looking back. ", // generatedLandscape = 3
            "You deciced to take the road through a small bit of forest. Deep in the thick vegitation you hear something rumble in the bushes.", // generatedLandscape = 4

             };



            int generatedLandscape = r.Next(0, Landscapes.Length);
            Console.WriteLine(Landscapes[generatedLandscape]);
        }


    }
}
