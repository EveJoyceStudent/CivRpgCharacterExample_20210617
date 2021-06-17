namespace CivRpgCharacterExample_20210617.models
{
    public class Weapon : Item
    {
        public int Damage { get; set; }
        public int Durability { get; set; }
        public int MaxDurability { get; set; }

        public Weapon() : base ("Sword", 10, 101){
            this.Damage = 10;
            this.MaxDurability = 100;
            this.Durability = this.MaxDurability;
        }
        
        public Weapon(string name, int weight, int value, int damage, int maxDurability) 
                    : base(name, weight, value) {
            this.Damage = damage;
            this.MaxDurability = maxDurability;
            this.Durability = this.MaxDurability;
        }

        public void Equip() {}
        public int Attack() { return 0; }



    }
}