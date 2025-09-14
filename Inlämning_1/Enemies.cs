
namespace Inlämning_1
{
    public class MobType
    {

        Random r = new Random();

        public string Name = "Corrupted Pilgrim";
        public int MaxHealt = 11;
        public int Strenght = 4;

        public string[] mobName = {"Infernal Hound", "Dustwalker", "Highwayman", "Evangelist of Revelation", "Corrupted Pilgrim"};
        public string[] eliteMob = { "Judge of the end times", "Fallen angel", "Cursed Bison" };


        public MobType ()
            {

            int isElite = r.Next(1, 6);

            if (isElite == 3)
            {
                int randomName = r.Next(0, eliteMob.Length);
                
                Name = eliteMob[randomName];
                MaxHealt = r.Next(5, 26);
                Strenght = r.Next(4, 15);

            } else
            {
                int randomName = r.Next(0,mobName.Length);

                Name = mobName[randomName];
                MaxHealt= r.Next(5, 16);
                Strenght= r.Next(4, 10);

            }
           
            }



       
        public MobType (string name, int HP, int power)
        {
            Name = name;
            MaxHealt = HP;
            Strenght = power;
        }

    }
}
