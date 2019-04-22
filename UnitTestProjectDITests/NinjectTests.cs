using System;
using ClassLibraryCharactersAndWeapons;
using ClassLibraryCharactersAndWeapons.NinjectModules;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;

namespace UnitTestProjectDITests
{
    [TestClass]
    public class NinjectTests
    {
        IKernel kernel;

        public NinjectTests()
        {
            kernel = new StandardKernel(new WarriorModule());
        }

        [TestMethod]
        public void SamuraiNinject()
        {
            //arrange
            Warrior warrior;

            string attackTarget = "Target";

            //act
            warrior = kernel.Get<Samurai>();

            //assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Samurai));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Katana));
            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void NinjaNinject()
        {
            //arrange
            Warrior warrior;

            string attackTarget = "Target";

            //act
            warrior = kernel.Get<Ninja>();

            //assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Ninja));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Sword));
            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void ClownNinject()
        {
            //arrange
            Warrior warrior;

            string attackTarget = "Target";

            //act
            warrior = kernel.Get<Clown>();

            //assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Clown));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Ballon));
            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void SpaceMarineNinject()
        {
            //arrange
            Warrior warrior;

            string attackTarget = "Target";

            //act
            warrior = kernel.Get<SpaceMarine>();

            //assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(SpaceMarine));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Flamethrower));
            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void ChildUnity()
        {
            //arrange
            Warrior warrior;

            string attackTarget = "Target";

            //act
            warrior = kernel.Get<Child>();

            //assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Child));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Ballon));
            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }
    }
}
