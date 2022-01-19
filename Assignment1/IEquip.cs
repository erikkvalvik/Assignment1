using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    interface IEquip
    {
        //Equips an armor item on a character
        public void EquipArmor(Armor item);
        public void UnequipArmor(Armor item);
        //equips a weapon item on a character
        public void EquipWeapon(Weapons item);
        public void UnequipWeapon();
    }
}
