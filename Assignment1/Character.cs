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
        public string name;
        public string race;
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
            if(characterClass == "Warrior")
            {
                attributes[0] += 4;
                attributes[1] += 1;
            }
            Console.WriteLine("A character has been created");
        }

    }
}
