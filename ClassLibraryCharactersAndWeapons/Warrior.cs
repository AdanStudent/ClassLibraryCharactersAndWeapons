using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryCharactersAndWeapons
{
    public abstract class Warrior
    {
        protected IWeapon weapon;

        public IWeapon Weapon
        {
            get { return weapon; }
            protected set { this.weapon = value; }
        }

        //functional dependancy on a weapon
        public Warrior(IWeapon w)
        {
            this.weapon = w;
        }

        public string Attack(string target)
        {
            return this.weapon.Hit(target);
        }
    }
}