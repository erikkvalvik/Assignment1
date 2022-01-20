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

        //Checks if weapon is usable for this class. Checks if a weapon is already equipped. 
        //Sets EquippedWeapon to chosen weapon. 
        //Should throw InvalidWeaponException if weapons item level is too high or of wrong weapon type
        public void EquipWeapon(Weapons item);
        public void UnequipWeapon();
    }
}
