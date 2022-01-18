using System;

namespace Assignment1
{
    public class RPGCharacters
    {
        static void Main(string[] args)
        {
            Character brute = new Character();
            Console.WriteLine($"name: {brute.name} race: {brute.race} class: {brute.characterClass}");
            Character warrior = new Character("Brutus", "Orc", "Warrior");
            Console.WriteLine($"name: {warrior.name} race: {warrior.race}  class: {warrior.characterClass}");
            Console.WriteLine($"{warrior.name}'s attributes.. Strength: {warrior.attributes[0]}. Dexterity: {warrior.attributes[1]}. Intelligence: {warrior.attributes[2]}");
        }
    }
}
