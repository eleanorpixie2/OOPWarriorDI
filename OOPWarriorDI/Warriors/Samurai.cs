using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPWarriorDI
{
    public class Samurai : Warrior
    {
        public Samurai(IWeapon weapon):base(weapon){}
    }
}