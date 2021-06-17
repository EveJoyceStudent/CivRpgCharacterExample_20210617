namespace CivRpgCharacterExample_20210617.models
{
    public class Ranged : Weapon
    {
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        
        public Ranged() : base("basic bow", 10, 10, 10, 10)
        {
            MinRange = 10;
            MaxRange = 100;
        }

        public Ranged(string name, int weight, int value, int damage, int maxDurability, int minRange, int maxRange) : base(name, weight, value, damage, maxDurability)
        {
            MinRange = minRange;
            MaxRange = maxRange;
        }
    }
}