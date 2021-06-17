namespace CivRpgCharacterExample_20210617.models
{
    public class Magic : Ranged
    {
        public int MpCost { get; set; }

        public Magic() : base("weak fireball", 0, 100, 20, 100, 0, 150)
        {
            MpCost = 8;
        }

        public Magic(string name, int weight, int value, int damage, int maxDurability, int minRange, int maxRange, int mpCost) : base(name, weight, value, damage, maxDurability, minRange, maxRange)
        {
            MpCost = mpCost;
        }
    }
}