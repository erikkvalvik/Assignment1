using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    interface ICalculateCharacterDamage
    {
        /// <summary>
        /// A simple method that, based on the characters class, returns its primary attribute.
        /// </summary>
        /// <returns>The given classes primary attribute as a double</returns>
        public double GetPrimaryAttribute();

        /// <summary>
        /// A method that calculates a characters damage. Should check if character has weapon equipped.
        /// A characters damage is calculated by: Weapons DPS * (1 + TotalPrimaryAttribute/100)
        /// </summary>
        /// <returns>Total character damage as a double</returns>
        public double CalculateCharacterDamage();
    }
}
