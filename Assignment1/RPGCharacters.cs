using System;

namespace Assignment1
{
    public class RPGCharacters
    {
        static void Main(string[] args)
        {
            
            Character warrior = new Character("Brutus", "Orc", "Warrior");
            Character mage = new Character("Leo", "Human", "Mage");
            Character ranger = new Character("Janna", "Elf", "Ranger");
            Character rogue = new Character("Popo", "Dwarf", "Rogue");
            printClassDetails(warrior);
            printClassDetails(mage);
            printClassDetails(ranger);
            printClassDetails(rogue);
            
        }

        public static void printClassDetails(Character charName)
        {
            Console.WriteLine($"name: {charName.name} race: {charName.race}  class: {charName.characterClass}");
            Console.WriteLine($"{charName.name}'s attributes.. Strength: {charName.attributes[0]}. Dexterity: {charName.attributes[1]}. Intelligence: {charName.attributes[2]}");
        }
    }
}
