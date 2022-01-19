using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Weapons, Armor
namespace Assignment1
{
    public class Items
    {
        public string Name;
        public int itemLevel;
        //private Character character = null;
        public bool isWeapon;
        public enum ItemSlot
        {
            Head,
            Body,
            Legs,
            Weapon

        }
        

        public Items()
        {
            Name = "The emperor's new shoulderpads";
            itemLevel = 1;
        }
        public Items(string name, int level)
        {
            this.Name = name;
            this.itemLevel = level;
        }
        


    }
}
