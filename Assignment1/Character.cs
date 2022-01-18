using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Mage, Ranger, Rogue, Warrior
namespace Assignment1
{
    public class Character
    {
        public string name { get; set; }
        public string race { get; set; }
        public string characterClass;
        public int[] attributes = new int[] { 1, 1, 1}; // attributes[0] = strength, [1] = Dexterity, [2] = Intelligence


        public Character()
        {
            name = "Unnamed";
            race = "Human";
            characterClass = "None";
            
        }
        public Character(string name, string race, string characterClass)
        {
            this.name = name;
            this.race = race;
            this.characterClass = characterClass;
            switch (characterClass)
            {
                case "Warrior":
                    attributes[0] += 4;
                    attributes[1] += 1;
                    break;
                case "Mage":
                    attributes[2] += 7;
                    break;
                case "Ranger":
                    attributes[1] += 6;
                    break;
                case "Rogue":
                    attributes[0] += 1;
                    attributes[1] += 5;
                    break;
            }
            Console.WriteLine("A character has been created");
        }

        //methods
        public void LevelUp(int amountOfLevels)
        {
            switch (characterClass)
            {
                case "Warrior":
                    attributes[0] += 3; //strength 
                    attributes[1] += 2; //dexterity
                    attributes[2] += 1; //intelligence
                    break;
                case "Mage":
                    attributes[0] += 1;
                    attributes[1] += 1;
                    attributes[2] += 5;
                    break;
                case "Ranger":
                    attributes[0] += 1;
                    attributes[1] += 5;
                    attributes[2] += 1;
                    break;
                case "Rogue":
                    attributes[0] += 1;
                    attributes[1] += 4;
                    attributes[2] += 1;
                    break;
            }
            Console.WriteLine($"{name} just leveled up {amountOfLevels} levels \n " +
                              $"strength: {attributes[0]} dexterity: {attributes[1]} intelligence: {attributes[2]}");
        }

    }
}
