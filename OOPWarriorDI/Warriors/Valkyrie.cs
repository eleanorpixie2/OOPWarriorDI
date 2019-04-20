using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPWarriorDI
{
    public class Valkyrie : Warrior
    {
        //valkyrie from siege that has a basic weapon
        public Valkyrie(IWeapon weapon) : base(weapon){ }
    }
}