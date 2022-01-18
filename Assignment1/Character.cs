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
        public string Name { get; set; }
        public string Race { get; set; }
        
        public CharacterClass characterClass;
        public EquipmentSlots headArmor;
        public EquipmentSlots bodyArmor;
        public EquipmentSlots legArmor;
        public EquipmentSlots Weapon;
        
        public struct Attributes
        {
            public int Strength;
            public int Dexterity;
            public int Intelligence;

            public Attributes(int strength, int dexterity, int intelligence)
            {
                Strength = strength;
                Dexterity = dexterity;
                Intelligence = intelligence;
            }
        }
        public enum CharacterClass
        {
            Mage,
            Ranger,
            Rogue,
            Warrior
        }
        public enum EquipmentSlots
        {
            Head,
            Body,
            Legs,
            Weapon
        }


        public Character()
        {
            Name = "Unnamed";
            Race = "Human";
            characterClass = CharacterClass.Warrior;
            
        }
        public Character(string name, string race, CharacterClass characterClass)
        {
            
            this.Name = name;
            this.Race = race;
            this.characterClass = characterClass;
            Console.WriteLine("A character has been created");
        }

        //methods

        public void Items(Items item)
        {

        }
        




    }
}
