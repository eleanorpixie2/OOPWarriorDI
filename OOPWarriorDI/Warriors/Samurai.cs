using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPWarriorDI
{
    public class Samurai : Warrior
    {
        //a samurai that has a generic weapon
        public Samurai(IWeapon weapon):base(weapon){}
    }
}