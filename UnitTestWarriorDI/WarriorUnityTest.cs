using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPWarriorDI;
using OOPWarriorDI.UnityContainers;
using Unity;
using Unity.Injection;

namespace UnitTestWarriorDI
{
  
    [TestClass]
    public class WarriorUnityTest
    {
        IUnityContainer unityContainer;
        public WarriorUnityTest()
        {
            //set up unity container
            unityContainer = new UnityContainer();
            WarriorContainer.RegisterTypes(unityContainer);
        }

        [TestMethod]
        public void SamuraiInject()
        {
            //Arrange
            Warrior warrior;
            string attackTarget = "target";

            //Act
            warrior = unityContainer.Resolve<Samurai>();

            //Assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Samurai));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Katana));
            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void NinjaInject()
        {
            //Arrange
            Warrior warrior;
            string attackTarget = "target";

            //Act
            warrior = unityContainer.Resolve<Ninja>();

            //Assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Ninja));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(Sword));
            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void ValkyrieInject()
        {
            //Arrange
            Warrior warrior;
            string attackTarget = "target";

            //Act
            warrior = unityContainer.Resolve<Valkyrie>();

            //Assert
            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Valkyrie));
            Assert.IsInstanceOfType(warrior.Weapon, typeof(SPAS_12));
            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }
    }
}
