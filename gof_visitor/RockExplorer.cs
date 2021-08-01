using System;

namespace gof_visitor
{
    public class RockExplorer : IExplorer
    {
        public void Visit(Mercury mercury)
        {
            Console.WriteLine("Exploring rock in mercury");
        }
        public void Visit(Mars mars)
        {
            Console.WriteLine("Exploring rock in mars");
        }
        public void Visit(Saturn saturn)
        {
            Console.WriteLine("Exploring rock in saturn");
        }
    }
}
