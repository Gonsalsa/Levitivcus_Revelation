
namespace Inlämning_1
{
    public class MobType
    {

        Random r = new Random();

        public string Name = "Corrupted Pilgrim";
        public int MaxHealt = 11;
        public int Strenght = 4;
        public int goldReward = 3;

        public string[] mobNames = { "Infernal Hound", "Dustwalker", "Highwayman", "Evangelist of Revelation", "Corrupted Pilgrim" };
        public string[] eliteMobs = { "Judge of the end times", "Fallen angel", "Cursed Bison" };


        public MobType()
        {

            int isElite = r.Next(1, 6);

            if (isElite == 3)
            {
                int randomName = r.Next(0, eliteMobs.Length);

                Name = eliteMobs[randomName];
                MaxHealt = r.Next(5, 26);
                Strenght = r.Next(4, 15);
                goldReward = r.Next(3, 10);


            }
            else
            {
                int randomName = r.Next(0, mobNames.Length);

                Name = mobNames[randomName];
                MaxHealt = r.Next(5, 16);
                Strenght = r.Next(4, 10);
                goldReward = r.Next(3, 6);

            }

        }


    }
}
