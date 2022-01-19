using System;

namespace Assignment1
{
    public class RPGCharacters
    {
        static void Main(string[] args)
        {
            
            Warrior warrior = new Warrior("Brutus", "Orc", Character.CharacterClass.Warrior);
            Mage mage = new Mage("Leo", "Human", Character.CharacterClass.Mage);
            Rogue rogue = new Rogue("Rogue", "Human", Character.CharacterClass.Rogue);
            Ranger ranger = new Ranger("Ranger", "Elf", Character.CharacterClass.Ranger);
            PrintClassDetails(warrior);
            PrintClassDetails(mage);
            PrintClassDetails(ranger);
            PrintClassDetails(rogue);
            warrior.PrintAttributes();
            warrior.LevelUp();
            warrior.PrintAttributes();
            mage.PrintAttributes();
            mage.LevelUp();
            mage.PrintAttributes();
            Armor armor1 = new Armor("Monkeys Chestplate", Armor.Material.Plate, 4, 0, 2, Items.ItemSlot.Body, 1);
            warrior.EquipArmor(armor1);
            warrior.PrintAttributes();
            warrior.UnequipArmor(armor1);
            warrior.PrintAttributes();
            


        }

        public static void PrintClassDetails(Character charName)
        {
            Console.WriteLine($"name: {charName.Name} race: {charName.Race}  class: {charName.characterClass}");
        }

        public static void GenerateItems()
        {

        }
    }
}
