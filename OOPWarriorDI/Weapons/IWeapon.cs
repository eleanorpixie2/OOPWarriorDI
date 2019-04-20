using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPWarriorDI
{
    //general weapon properties
    public interface IWeapon
    {
        //name of weapon
        string Name { get;}

        //weapon attack
        string Hit(string target);
    }
}