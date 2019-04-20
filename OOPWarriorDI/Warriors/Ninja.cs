using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPWarriorDI
{
    public class Ninja : Warrior
    {
        //a ninja that has a weapon
        public Ninja(IWeapon weapon):base(weapon){}
    }
}