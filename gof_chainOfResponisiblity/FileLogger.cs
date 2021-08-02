using System;

namespace gof_chainOfResponisiblity
{
    public class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            this.level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine($"FileLogger::Logger: { message}");
        }
    }
}
