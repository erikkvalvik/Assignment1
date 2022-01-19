using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Rogue: Character, ILevelUp, IEquip
    {
        //sets base attributes attributes[0] = strength, [1] = Dexterity, [2] = Intelligence
        Attributes attributes = new Attributes(2, 6, 1);
        ArmorType armorMat = new ArmorType(false, true, true, false);
        public Weapons EquippedWeapon;
        public bool IsWeaponEquipped;

        public Rogue(string name, string race, CharacterClass characterClass)
        {
            IsWeaponEquipped = false;
            this.Name = name;
            this.Race = race;
            this.characterClass = characterClass;
            usableWeapons.Add(Weapons.WeaponType.Dagger);
            usableWeapons.Add(Weapons.WeaponType.Sword);
            Console.WriteLine("A rogue has been created");
        }

        //Should add specific armor item to an existing item slot.
        public void EquipArmor(Armor item)
        {
            //Checks if character is high enough level to equip item
            if (item.itemLevel > this.Level)
            {
                Console.WriteLine("You are not high enough level to equip this item");
                return;
            }
            //Checks if armor type matches the characters class armor types. Adds items attributes to characters attributes,
            //adds armor item to equipped items list
            if (item.armorType.ToString() == "Mail" || item.armorType.ToString() == "Leather")
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
        //Checks if weapon is usable for this class. Checks if a weapon is already equipped. 
        //Sets EquippedWeapon to chosen weapon. 
        public void EquipWeapon(Weapons item)
        {
            if (item.itemLevel > Level)
            {
                //Throw exception
                return;
            }
            if (usableWeapons.Contains(item.weaponType))
            {

                if (!IsWeaponEquipped)
                {
                    EquippedWeapon = item;
                    IsWeaponEquipped = true;
                    Console.WriteLine($"equipped {item.Name}");
                    return;
                }
                Console.WriteLine("Weapon slot is full");
                return;
            }
            else
            {
                //Throw InvalidWeaponException
                return;
            }
            
        }
        //Checks if a weapon is equipped. Sets EquippedWeapon to null if a weapon is equipped.
        public void UnequipWeapon()
        {
            //if(EquippedWeapon == null)
            //{
            //    Console.WriteLine("No weapon equipped");
            //    return;
            //} unsure if necessary
            if (IsWeaponEquipped)
            {
                EquippedWeapon = null;
                IsWeaponEquipped = false;
                return;
            }
            Console.WriteLine("No weapon to unequip");
            return;
        }
        //Increases the level and attributes of the rogue class
        public void LevelUp()
        {
            Level += 1;
            attributes.Strength += 1;
            attributes.Dexterity += 4;
            attributes.Intelligence += 1;
            Console.WriteLine($"Rogue {this.Name} just leveled up! Current level: {Level}");
        }

        public void PrintAttributes()
        {
            Console.WriteLine($"{Name} the {characterClass} has {attributes.Strength} strength, {attributes.Dexterity} dexterity and {attributes.Intelligence} intelligence!");
        }
    }
}
