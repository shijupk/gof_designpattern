namespace gof_chainOfResponisiblity
{
    public abstract class AbstractLogger
    {
        public const int DEBUG = 1;
        public const int INFO = 2;
        public const int ERROR = 3;

        protected int level;

        //next element in chain or responsibility
        protected AbstractLogger nextLogger;
        public void SetNextLogger(AbstractLogger nextLogger)
        {
            this.nextLogger = nextLogger;
        }

        public void LogMessage(int level, string message)
        {
            if (this.level <= level)
            {
                Write(message);
            }
            if (nextLogger != null)
            {
                nextLogger.LogMessage(level, message);
            }
        }

        abstract protected void Write(string message);
    }
}
