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
        public int Level;
        public List<Items> equippedItems = new List<Items>();
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
        public struct ArmorType
        {
            public bool Cloth;
            public bool Leather;
            public bool Mail;
            public bool Plate;

            public ArmorType(bool cloth, bool leather, bool mail, bool plate)
            {
                Cloth = cloth;
                Leather = leather;
                Mail = mail;
                Plate = plate;
            }
        }
        public enum CharacterClass
        {
            Mage,
            Ranger,
            Rogue,
            Warrior
        }
        public struct EquipmentSlots
        {
            public Items.ItemSlot Head;
            public Items.ItemSlot Body;
            public Items.ItemSlot Legs;
            public Items.ItemSlot Weapon;
        }


        public Character()
        {
            Name = "Unnamed";
            Race = "Human";
            Level = 1;
            characterClass = CharacterClass.Warrior;
            
        }
        public Character(string name, string race, CharacterClass characterClass)
        {
            
            this.Name = name;
            this.Race = race;
            this.Level = 1;
            this.characterClass = characterClass;
            Console.WriteLine("A character has been created");
        }

        //methods

        public void Items(Items item)
        {

        }
        




    }
}
