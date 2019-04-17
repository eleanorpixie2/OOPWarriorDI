using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPWarriorDI
{
    public class Valkyrie : Warrior
    {
        public Valkyrie(IWeapon weapon) : base(weapon){ }
    }
}