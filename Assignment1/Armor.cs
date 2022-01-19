using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Armor : Items //, IEquip
    {
        public Material armorType;
        public ItemSlot itemSlot;
        public int armorStrength;
        public int armorIntelligence;
        public int armorDexterity;
        
        public enum Material
        {
            Cloth,
            Leather,
            Mail,
            Plate
        }
        

        //creates an armor object with default values.
        public Armor()
        {
            Name = "default";
            isWeapon = false;
            armorType = Material.Cloth;
            armorStrength = 1;
            armorIntelligence = 1;
            armorDexterity = 1;
            itemSlot = ItemSlot.Body;
        }

        public Armor(string name, Material type, int strength, int intelligence, int dexterity, ItemSlot slot, int itemlvl)
        {
            Name = name;
            isWeapon = false;
            armorType = type;
            armorStrength = strength;
            armorIntelligence = intelligence;
            armorDexterity = dexterity;
            itemSlot = slot;
            itemLevel = itemlvl;
            
            Console.WriteLine($"New {armorType} {itemSlot} armor, {Name} created {itemLevel}. ");
        }

    }
}
