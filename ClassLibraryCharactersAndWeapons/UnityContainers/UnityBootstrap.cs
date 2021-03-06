﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace ClassLibraryCharactersAndWeapons.UnityContainers
{
    public static class UnityBootstrap
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IWeapon, Sword>();
            container.RegisterType<Samurai>(new InjectionConstructor(new Katana()));
            container.RegisterType<SpaceMarine>(new InjectionConstructor(new Flamethrower()));
            container.RegisterType<Clown>(new InjectionConstructor(new Ballon()));
            container.RegisterType<Child>(new InjectionConstructor(new Ballon()));

        }
    }
}
