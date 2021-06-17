using System;
using CivRpgCharacterExample_20210617.models;

namespace CivRpgCharacterExample_20210617
{
    class Program
    {
        static void Main(string[] args)
        {
            Item healthPotion = new Item("Health Potion", 2, 10);
            Item stone = new Item("Stone", 1, 0);
            Item herb = new Item("Herb", 1, 2);
            Item hat = new Item("Magic Cap", 2, 100);

            Weapon hammer = new Weapon("Hammer", 20, 200, 10, 100);
            //TODO: uncommment the below when you've created the Ranged and Magic classes
            //Ranged bow = new Ranged("Bow", 10, 200, 5, 50, 1, 5);
            //Magic wand = new Magic("Wand of Pestilence", 10, 200, 5, 50, 1, 5, 2);

            RpgCharacter fred = new RpgCharacter("Fred", 200, 20);
            RpgCharacter defaultCharacter = new RpgCharacter();

            fred.BackPack.AddNewItem(healthPotion);
            fred.BackPack.AddNewItem(stone);
            fred.BackPack.AddNewItem(hat);
            //TODO: add herb to Fred's backpack
            //TODO: add another Health Potion to Fred's backpack
            //TODO: add hammer to Fred's backpack
            

            //TODO: Sort Fred's backpack by Weight
            System.Console.WriteLine($"Fred's backpack\n {fred.BackPack.ListItems()}");
            //TODO: Print the current capacity of Fred's backpack
            //TODO: Print the number of Health Potions in Fred's backpack


            defaultCharacter.BackPack.SortByName();
            System.Console.WriteLine($"Dephoult's backpack\n {defaultCharacter.BackPack.ListItems()}");

            // To cast (convert) an object into a subtype use the example below.  Turns an item into a weapon in this case
            // ((Weapon)defaultCharacter.BackPack.Items[0])
            System.Console.WriteLine($"{defaultCharacter.BackPack.Items[0].Name} damage: {((Weapon)defaultCharacter.BackPack.Items[0]).Damage}");            

            // go through default's backpack and see what's an item and what's a weapon
            foreach(Item i in defaultCharacter.BackPack.Items) {
                if (i is Item) {
                    System.Console.WriteLine($"{i.Name} is an Item");
                }

                if (i is Weapon) {
                    System.Console.WriteLine($"{i.Name} is an Weapon");
                }
            }
        }
    }
}
