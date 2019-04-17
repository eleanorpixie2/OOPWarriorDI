using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using OOPWarriorDI;
using OOPWarriorDI.NinjectModules;

namespace UnitTestWarriorDI
{
    [TestClass]
    public class WarriorNinjectTest
    {
        IKernel kernel;

        public WarriorNinjectTest()
        {
            kernel = new StandardKernel(new WarriorModule());
        }
        [TestMethod]
        public void SamuraiInject()
        {
            //Arrange
            Warrior warrior;
            string attackTarget = "target";

            //Act
            warrior = kernel.Get<Samurai>();

            //Assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Samurai));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Katana));
            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void ValkyrieInject()
        {
            //Arrange
            Warrior warrior;
            string attackTarget = "target";

            //Act
            warrior = kernel.Get<Valkyrie>();

            //Assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Valkyrie));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(SPAS_12));
            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void NinjaInject()
        {
            //Arrange
            Warrior warrior;
            string attackTarget = "target";

            //Act
            warrior = kernel.Get<Ninja>();

            //Assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Ninja));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Sword));
            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }
    }
}
