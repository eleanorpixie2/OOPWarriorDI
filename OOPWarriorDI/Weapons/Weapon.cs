using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPWarriorDI
{
    public abstract class Weapon : IWeapon
    {
        protected string name;
        public string Name { get { return name; } }

        public Weapon()
        {
            name = "weapon";
        }

        public string Hit(string target)
        {
            return $"{name} hits {target}";
        }
    }
}