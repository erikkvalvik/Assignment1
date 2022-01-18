using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Armor : Items //, IEquip
    {
        public Material armorType;
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
            isWeapon = false;
            armorType = Material.Cloth;
            armorStrength = 1;
            armorIntelligence = 1;
            armorDexterity = 1;
        }

        public Armor(Material type, int strength, int intelligence, int dexterity)
        {
            isWeapon = false;
            armorType = type;
            armorStrength = strength;
            armorIntelligence = intelligence;
            armorDexterity = dexterity;
        }

    }
}
