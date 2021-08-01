using System;

namespace gof_visitor
{
    public class LifeExplorer : IExplorer
    {
        public void Visit(Mercury mercury)
        {
            Console.WriteLine("Exploring life in mercury");
        }
        public void Visit(Mars mars)
        {
            Console.WriteLine("Exploring life in mars");
        }
        public void Visit(Saturn saturn)
        {
            Console.WriteLine("Exploring life in saturn");
        }
    }
}
