using System;

namespace gof_chainOfResponisiblity
{
    class Program
    {
        private static AbstractLogger GetChainOfLoggers()
        {

            AbstractLogger errorLogger = new EventLogger(AbstractLogger.ERROR);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.INFO);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.DEBUG);

            errorLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(consoleLogger);

            return errorLogger;
        }

        static void Main(string[] args)
        {
            AbstractLogger loggerChain = GetChainOfLoggers();

            Console.WriteLine("-----Logger 1 Debug level, should only handled by console-----------");
            //Only consoleLogger
            loggerChain.LogMessage(AbstractLogger.DEBUG,
               "This is an information.");
            Console.WriteLine("-----Logger 2 Info level, should handle by console and file-----------");
            //file + console
            loggerChain.LogMessage(AbstractLogger.INFO,
               "This is an debug level information.");

            Console.WriteLine("-----Logger 3----------- Error Level, should handle by all loggers");
            //file+console+event+error
            loggerChain.LogMessage(AbstractLogger.ERROR,
               "This is an error information.");

            Console.ReadKey();
        }
    }
}
