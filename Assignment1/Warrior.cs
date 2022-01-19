using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Warrior : Character, ILevelUp//, IEquip
    {
        //sets base attributes attributes[0] = strength, [1] = Dexterity, [2] = Intelligence
        Attributes attributes = new Attributes(5, 1, 1);
        ArmorType armorMat = new ArmorType(false, false, true, true);
        public int PrimaryAttribute;

        public Warrior(string name, string race, CharacterClass characterClass)
        {

            this.Name = name;
            this.Race = race;
            this.characterClass = characterClass;
            Console.WriteLine("A warrior has been created");
        }

        //Should add specific armor item to an existing item slot.
        public void EquipArmor(Armor item)
        {
            //Checks if character is high enough level to equip item
            if(item.itemLevel > this.Level)
            {
                Console.WriteLine("You are not high enough level to equip this item");
                return;
            }
            //Checks if armor type matches the characters class armor types. Adds items attributes to characters attributes,
            //adds armor item to equipped items list
            if(item.armorType.ToString() == "Mail" || item.armorType.ToString() == "Plate")
            {
                attributes.Strength += item.armorStrength;
                attributes.Dexterity += item.armorDexterity;
                attributes.Intelligence += item.armorIntelligence;
                equippedItems.Add(item);
                Console.WriteLine($"Equipped {item.Name} on {item.itemSlot}");
                return;
                
            }
            else
            {
                Console.WriteLine("Can't use this type of armor");
            }
            return;
            
        }
        //Should remove armor item from character and remove armor attributes from character attributes
        public void UnequipArmor(Armor item)
        {
            //checks if armor item is equipped
            if (equippedItems.Contains(item))
            {
                //Removes attributes from character attributes and armor item from equipped list.
                attributes.Strength -= item.armorStrength;
                attributes.Dexterity -= item.armorDexterity;
                attributes.Intelligence -= item.armorIntelligence;
                equippedItems.Remove(item);
                Console.WriteLine($"Unequipped {item}");
            }
            return;
        }
        //Increases the level and attributes of the warrior class
        public void LevelUp()
        {
            Level += 1;
            attributes.Strength += 5;
            attributes.Dexterity += 1;
            attributes.Intelligence += 1;
            Console.WriteLine($"Warrior {this.Name} just leveled up! Current level: {Level}");
        }

        public void PrintAttributes()
        {
            Console.WriteLine($"{Name} the {characterClass} has {attributes.Strength} strength, {attributes.Dexterity} dexterity and {attributes.Intelligence} intelligence!");
        }

    }
}
