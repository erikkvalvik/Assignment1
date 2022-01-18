using System;

namespace Assignment1
{
    public class RPGCharacters
    {
        static void Main(string[] args)
        {
            
            Warrior warrior = new Warrior("Brutus", "Orc", Character.CharacterClass.Warrior);
            Mage mage = new Mage("Leo", "Human", Character.CharacterClass.Mage);
            Character ranger = new Character("Janna", "Elf", Character.CharacterClass.Ranger);
            Character rogue = new Character("Popo", "Dwarf", Character.CharacterClass.Rogue);
            printClassDetails(warrior);
            printClassDetails(mage);
            printClassDetails(ranger);
            printClassDetails(rogue);
            warrior.PrintAttributes();
            warrior.LevelUp();
            warrior.PrintAttributes();
            mage.PrintAttributes();
            mage.LevelUp();
            mage.PrintAttributes();


        }

        public static void printClassDetails(Character charName)
        {
            Console.WriteLine($"name: {charName.Name} race: {charName.Race}  class: {charName.characterClass}");
        }
    }
}
