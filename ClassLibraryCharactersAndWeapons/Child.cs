using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryCharactersAndWeapons
{
    public class Child : Warrior
    {
        public Child(IWeapon w) : base(w)
        {

        }
    }
}