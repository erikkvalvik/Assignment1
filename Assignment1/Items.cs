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
        private string name;
        private int itemLevel;
        //private Character character = null;
        public bool isWeapon;
        public enum ItemSlot
        {
            Head,
            Body,
            Legs,
            Weapon

        }
        //public Items(Character obj)
        //{
        //    this.character = obj;
        //}

        public Items()
        {
            name = "The emperor's new shoulderpads";
            itemLevel = 1;
        }
        public Items(string name, int level)
        {
            this.name = name;
            this.itemLevel = level;
        }
        


    }
}
