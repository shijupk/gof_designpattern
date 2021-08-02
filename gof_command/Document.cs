using System;

namespace gof_command
{
    public class Document
    {
        public void Copy()
        {
            Console.WriteLine("Content copied");
        }

        public void Paste()
        {
            Console.WriteLine("Content pasted");
        }
    }
}
