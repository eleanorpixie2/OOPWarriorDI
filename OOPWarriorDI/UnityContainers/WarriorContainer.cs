using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace OOPWarriorDI.UnityContainers
{
    public static class WarriorContainer
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            //will put a sword where ever a IWeapon is needed
            container.RegisterType<IWeapon, Sword>();
            //makes a samurai with a katana
            container.RegisterType<Samurai>(new InjectionConstructor(new Katana()));
            //valkyrie always has a shotgun
            container.RegisterType<Valkyrie>(new InjectionConstructor(new SPAS_12()));
        }
    }
}
