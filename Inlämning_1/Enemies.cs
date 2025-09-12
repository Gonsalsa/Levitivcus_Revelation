
namespace Inlämning_1
{
    public class MobType
    {

        public string Name = "Corrupted Pilgrim";
        public int MaxHealt = 11;
        public int Strenght = 4;

        public string[] mobName = {"Infernal Hound", "Dustwalker", "Highwayman", "Evangelist of Revelation"};
       
        public MobType (string name, int HP, int power)
        {
            Name = name;
            MaxHealt = HP;
            Strenght = power;
        }

    }
}
