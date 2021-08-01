using System.Collections.Generic;

namespace gof_visitor
{
    /// <summary>
    /// Program to demonstrate gof visitor patterns
    /// it is basically a emulation of double dispatch
    /// can create any number of visitors with out modifing planet
    /// But adding a planet requires modificatin in explorers Wich is violation of Oopen/close prociple
    /// when the elemements are known in advance but operation can be extended (like planets are known and explorers are extendable)
    /// when type of the element and operation are not not known during runtime, but the correct methiod need to be invoked(the types of nboth planet
    /// and explorer are not known during runtime)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IPlanet mars = new Mars();
            IPlanet saturn = new Saturn();
            IPlanet mercury = new Mercury();

            IExplorer lifeExplorer = new LifeExplorer();
            IExplorer rockExplorer = new RockExplorer();
            List<IPlanet> planetsToVisit = new() { mars, saturn, mercury };

            foreach (IPlanet planet in planetsToVisit)
            {
                planet.Accept(lifeExplorer);
                planet.Accept(rockExplorer);
            }
        }
    }
}
