using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Ninject.Injection;

namespace OOPWarriorDI.NinjectModules
{
    public class WarriorModule : NinjectModule
    {
        public override void Load()
        {
            //every warrior not specified below gets a sword
            this.Bind<IWeapon>().To<Sword>();
            //samurai get a katana
            this.Bind<IWeapon>().To<Katana>().WhenInjectedExactlyInto<Samurai>();
            //valkyrie gets a SPAS-12 shoutgun
            this.Bind<IWeapon>().To<SPAS_12>().WhenInjectedExactlyInto<Valkyrie>();
        }
    }
}
