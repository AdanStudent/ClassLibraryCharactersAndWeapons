using System;
using ClassLibraryCharactersAndWeapons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectDITests
{
    [TestClass]
    public class WarriorTest
    {
        [TestMethod]
        public void SamuraiNoInject()
        {
            //arrange
            Weapon weapon;
            Warrior warrior;

            string attackTarget = "Target";

            //act
            weapon = new Katana();
            warrior = new Samurai(weapon);

            //assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Samurai));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Katana));
            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }

    }
}
