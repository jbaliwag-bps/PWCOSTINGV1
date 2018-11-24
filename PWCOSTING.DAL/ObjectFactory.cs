using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using StructureMap;

namespace PWCOSTING.DAL
{
    public static class ObjectFactory
    {
        private static IContainer container;
        public static void Startup()
        {
            container = Container.For<ConsoleRegistry>();
        }

        public static IContainer GetContainer()
        {
            return container;
        }

        public class ConsoleRegistry : Registry
        {
            public ConsoleRegistry()
            {
                Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });
                // requires explicit registration; doesn't follow convention
                For<AppDBContext>().Use(() => new AppDBContext());
            }
        }
    }
}
