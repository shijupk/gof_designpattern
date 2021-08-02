using System;

namespace gof_chainOfResponisiblity
{
    public class EventLogger : AbstractLogger
    {
        public EventLogger(int level)
        {
            this.level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine($"EventLogger::Logger: { message}");
        }
    }
}
