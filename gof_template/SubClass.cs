using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gof_template
{
    public class SubClass: AbstractClass
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
