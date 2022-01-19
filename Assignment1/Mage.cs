using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Mage : Character, ILevelUp
    {
        
        //sets base attributes attributes[0] = strength, [1] = Dexterity, [2] = Intelligence
        Attributes attributes = new Attributes(1, 1, 8);
        ArmorType armorType = new ArmorType(true, false, false, false); //(Cloth, Leather, Mail, Plate)
        public Mage(string name, string race, CharacterClass characterClass)
        {
            this.Name = name;
            this.Race = race;
            this.characterClass = characterClass;
            Console.WriteLine($"{Name} the {characterClass} has been created");
        }
        public void LevelUp()
        {
            Level += 1;
            attributes.Strength += 1;
            attributes.Dexterity += 1;
            attributes.Intelligence += 5;
            Console.WriteLine($"{Name} the {characterClass} just leveled up! Current level: {Level}");
        }
        public void PrintAttributes()
        {
            Console.WriteLine($"{Name} the {characterClass} has {attributes.Strength} strength, {attributes.Dexterity} dexterity and {attributes.Intelligence} intelligence!");
        }
    }
}
