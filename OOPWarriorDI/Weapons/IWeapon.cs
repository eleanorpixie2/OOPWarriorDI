using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPWarriorDI
{
    public interface IWeapon
    {
        string Name { get;}

        string Hit(string target);
    }
}