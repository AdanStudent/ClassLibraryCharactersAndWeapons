using System;
using ClassLibraryCharactersAndWeapons;
using ClassLibraryCharactersAndWeapons.UnityContainers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;

namespace UnitTestProjectDITests
{
    [TestClass]
    public class UnityTests
    {
        IUnityContainer container;

        public UnityTests()
        {
            container = new UnityContainer();
            UnityBootstrap.RegisterTypes(container);
        }

        [TestMethod]
        public void ClownUnity()
        {
            //arrange
            Warrior warrior;

            string attackTarget = "Target";

            //act
            warrior = container.Resolve<Clown>();

            //assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Clown));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Ballon));
            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void NinjaUnity()
        {
            //arrange
            Warrior warrior;

            string attackTarget = "Target";

            //act
            warrior = container.Resolve<Ninja>();

            //assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Ninja));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Sword));
            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void SamuraiUnity()
        {
            //arrange
            Warrior warrior;

            string attackTarget = "Target";

            //act
            warrior = container.Resolve<Samurai>();

            //assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Samurai));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Katana));
            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void SpaceMarineUnity()
        {
            //arrange
            Warrior warrior;

            string attackTarget = "Target";

            //act
            warrior = container.Resolve<SpaceMarine>();

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
            warrior = container.Resolve<Child>();

            //assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Child));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Ballon));
            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }
    }
}
