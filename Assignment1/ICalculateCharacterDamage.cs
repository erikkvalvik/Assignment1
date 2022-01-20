using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    interface ICalculateCharacterDamage
    {
        public double GetPrimaryAttribute();
        public double CalculateCharacterDamage();
    }
}
