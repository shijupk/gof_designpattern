using System;

namespace gof_template
{
    class Program
    {
        static void Main(string[] args)
        {
            var subClass = new SubClass();
            subClass.TemplateMethod();

           Console.ReadKey();
        }
    }
}
