using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Weapons : Items//, IEquip
    {
        public WeaponType weaponType;
        public double baseDamage;
        public double attacksPerSecond;
        public double weaponDPS;
        public ItemSlot slot;
        
        public enum WeaponType
        {
            Axe,
            Bow,
            Dagger,
            Hammer,
            Staff,
            Sword,
            Wand
        }
        
        //Generates default weapon
        public Weapons()
        {
            itemLevel = 1;
            slot = ItemSlot.Weapon;
            weaponType = WeaponType.Sword;
            baseDamage = 1;
            attacksPerSecond = 1;
            
        }
        public Weapons(string name, int itemlvl, WeaponType type, double bdmg, double aps)
        {
            Name = name;
            itemLevel = itemlvl;
            slot = ItemSlot.Weapon;
            weaponType = type;
            baseDamage = bdmg;
            attacksPerSecond = aps;
            weaponDPS = GetDPS();

        }

        public double GetDPS()
        {
            return baseDamage * attacksPerSecond;
        }
    }
}
