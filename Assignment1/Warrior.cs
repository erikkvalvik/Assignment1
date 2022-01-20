using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Warrior : Character, ILevelUp, IEquip, ICalculateCharacterDamage
    {
        //sets base attributes attributes[0] = strength, [1] = Dexterity, [2] = Intelligence
        Attributes attributes = new Attributes(5, 1, 1);
        ArmorType armorMat = new ArmorType(false, false, true, true);
        
        public Weapons EquippedWeapon;
        public bool IsWeaponEquipped;

        public Warrior(string name, string race, CharacterClass characterClass)
        {
            IsWeaponEquipped = false;
            this.Name = name;
            this.Race = race;
            this.characterClass = characterClass;
            usableWeapons.Add(Weapons.WeaponType.Axe);
            usableWeapons.Add(Weapons.WeaponType.Hammer);
            usableWeapons.Add(Weapons.WeaponType.Sword);
            Console.WriteLine("A warrior has been created");
        }

        //Should add specific armor item to an existing item slot.
        public void EquipArmor(Armor item)
        {
            //Checks if character is high enough level to equip item. Should throw InvalidArmorException if not.
            if (item.itemLevel > this.Level)
            {
                throw new InvalidArmorException();
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
                throw new InvalidArmorException();
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
            else
            {
                throw new InvalidUnequipException();
            }
            return;
        }
        //Checks if weapon is usable for this class. Checks if a weapon is already equipped. 
        //Sets EquippedWeapon to chosen weapon. 
        public void EquipWeapon(Weapons item)
        {
            if (item.itemLevel > Level)
            {
                throw new InvalidWeaponException();
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
                throw new InvalidWeaponException();
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
            else
            {
                throw new InvalidUnequipException();
            }

        }
        //Increases the level and attributes of the warrior class
        public void LevelUp()
        {
            Level += 1;
            attributes.Strength += 3;
            attributes.Dexterity += 2;
            attributes.Intelligence += 1;
            Console.WriteLine($"Warrior {this.Name} just leveled up! Current level: {Level}");
        }
        //Gets the primary attribute for this class
        //Gets the primary attribute for this class
        public double GetPrimaryAttribute()
        {
            return attributes.Dexterity;
        }
        //Calculates the Character damage as described in Appendix B: 4.1) Total attributes and calculations
        public double CalculateCharacterDamage()
        {
            double primaryAttribute = GetPrimaryAttribute();
            double dmgPercent = primaryAttribute / 100;
            double baseDamage = 1 + (dmgPercent);

            Console.WriteLine("basedamage " + baseDamage + "dmgpercent " + dmgPercent);
            if (IsWeaponEquipped)
            {
                return (EquippedWeapon.GetDPS() * baseDamage);
            }
            else
            {
                return 1 + (primaryAttribute / 100);
            }
        }

        //Displays character stats by Name, Level, Attributes and Damage
        public void DisplayStats()
        {
            Console.WriteLine($"\nName: {Name} \nClass: {characterClass} \nLevel: {Level} \nStrength: {attributes.Strength} \n" +
                $"Dexterity: {attributes.Dexterity} \nIntelligence: {attributes.Intelligence} \nDamage: {CalculateCharacterDamage()}\n");
        }

    }
}
