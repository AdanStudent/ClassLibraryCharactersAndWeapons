using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryCharactersAndWeapons
{
    public abstract class Weapon : IWeapon
    {
        protected string name;

        public string Name
        {
            get { return name; }
            set { }
        }

        public Weapon()
        {
            this.name = "Not a weapon";
        }

        public string Hit(string target)
        {
            return $"{this.name} hits {target}";
        }

    }
}