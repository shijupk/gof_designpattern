using System;

namespace gof_template
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            this.BaseOperation();
            this.SubClassOnlyOperation();
            this.SubClassCanOverride();
        }

        protected void BaseOperation()
        {
            Console.WriteLine("AbstractClass: BaseOperation");
        }

        //  required implmentaion is sub calss but no pasing to its subclass
        protected abstract void SubClassOnlyOperation();
        protected virtual void SubClassCanOverride()
        {
            Console.WriteLine("AbstractClass: SubClassHook");
        }

    }
}
