using System;

namespace gof_chainOfResponisiblity
{
    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int level)
        {
            this.level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine($"ConsoleLogger::Logger: { message}");
        }
    }
}
