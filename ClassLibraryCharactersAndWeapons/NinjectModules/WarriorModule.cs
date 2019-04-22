using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace ClassLibraryCharactersAndWeapons.NinjectModules
{
    public class WarriorModule : NinjectModule
    {
        public override void Load()
        {
            //if any class need an IWeapon it will be a sword
            this.Bind<IWeapon>().To<Sword>();
            this.Bind<IWeapon>().To<Katana>().WhenInjectedInto<Samurai>();
            this.Bind<IWeapon>().To<Ballon>().WhenInjectedInto<Clown>();
            this.Bind<IWeapon>().To<Ballon>().WhenInjectedInto<Child>();
            this.Bind<IWeapon>().To<Flamethrower>().WhenInjectedInto<SpaceMarine>();

        }
    }
}
