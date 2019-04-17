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
            this.Bind<IWeapon>().To<Sword>();
            this.Bind<IWeapon>().To<Katana>().WhenInjectedExactlyInto<Samurai>();
            this.Bind<IWeapon>().To<SPAS_12>().WhenInjectedExactlyInto<Valkyrie>();
        }
    }
}
