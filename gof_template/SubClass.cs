using System;

namespace gof_template
{
    public class SubClass : AbstractClass
    {
        protected override void SubClassOnlyOperation()
        {
            Console.WriteLine("SubClass: SubClassOnlyOperation");
        }

        protected override void SubClassCanOverride()
        {
            Console.WriteLine("SubClass: SubClassHook");
        }
    }
}
