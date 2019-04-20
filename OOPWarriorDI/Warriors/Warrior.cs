using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPWarriorDI
{
    public class Warrior
    {
        //warrior's weapon
        protected IWeapon weapon;
        public IWeapon Weapon
        {
            get { return weapon; }
            protected set { weapon = value; }
        }

        //constructor that sets the warrior's weapon
        public Warrior(IWeapon weapon)
        {
            Weapon = weapon;
        }

        //attack with equipped weapon
        public string Attack(string target)
        {
            return weapon.Hit(target);
        }
    }
}