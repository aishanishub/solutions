using System;

namespace SingletonPatternExample
{
    // Step 2: Define the Singleton Logger class
    public class Logger
    {
        // Step 3: Private static instance
        private static Logger _instance;

        // Step 4: Private constructor
        private Logger()
        {
            Console.WriteLine("Logger Initialized");
        }

        // Step 5: Public static method to get the instance
        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        // A sample log method
        public void Log(string message)
        {
            Console.WriteLine("[LOG] " + message);
        }
    }

    // Step 6: Program to test the Singleton
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            logger1.Log("This is the first log message.");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("This is the second log message.");

            if (logger1 == logger2)
            {
                Console.WriteLine("Only one instance of Logger is used.");
            }
            else
            {
                Console.WriteLine(" Different Logger instances exist.");
            }
        }
    }
}
