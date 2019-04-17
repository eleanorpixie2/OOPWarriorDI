using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPWarriorDI
{
    public class Warrior
    {
        protected IWeapon weapon;
        public IWeapon Weapon
        {
            get { return weapon; }
            protected set { weapon = value; }
        }

        public Warrior(IWeapon weapon)
        {
            Weapon = weapon;
        }


        public string Attack(string target)
        {
            return weapon.Hit(target);
        }
    }
}