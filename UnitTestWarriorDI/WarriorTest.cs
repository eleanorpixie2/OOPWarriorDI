using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPWarriorDI;

namespace UnitTestWarriorDI
{
    [TestClass]
    public class WarriorTest
    {
        [TestMethod]
        public void SamuraiNoInject()
        {
            //Arrange
            Weapon weapon;
            Warrior warrior;
            string attackTarget = "target";

            //Act
            weapon = new Katana();
            warrior = new Samurai(weapon);

            //Assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Samurai));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Katana));
            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void NinjaNoInject()
        {
            //Arrange
            Weapon weapon;
            Warrior warrior;
            string attackTarget = "target";

            //Act
            weapon = new Sword();
            warrior = new Ninja(weapon);

            //Assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Ninja));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Sword));
            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }
    }
}
