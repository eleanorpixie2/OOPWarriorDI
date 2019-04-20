using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPWarriorDI
{
    public abstract class Weapon : IWeapon
    {
        //name of weapon
        protected string name;
        public string Name { get { return name; } }

        //constructor
        public Weapon()
        {
            name = "weapon";
        }

        //hit function that returns a string
        public string Hit(string target)
        {
            return $"{name} hits {target}";
        }
    }
}