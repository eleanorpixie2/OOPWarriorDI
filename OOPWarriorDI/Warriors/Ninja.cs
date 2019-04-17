using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPWarriorDI
{
    public class Ninja : Warrior
    {
        public Ninja(IWeapon weapon):base(weapon){}
    }
}