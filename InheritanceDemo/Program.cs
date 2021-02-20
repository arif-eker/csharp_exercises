using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        //RECAP DEMO 2
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            //customerManager.Logger = new DatabaseLogger();
            customerManager.Logger = new FileLogger();
            customerManager.Add();

            Console.ReadLine();
        }

        class CustomerManager
        {
            public ILogger Logger { get; set; }
            public void Add()
            {
                Logger.Log();
                Console.WriteLine("Customer added!");
            }
        }

        class SmsLogger: ILogger
        {
            public void Log()
            {
                Console.WriteLine("Sms Logged");
            }
        }
        class DatabaseLogger: ILogger
        {
            public void Log()
            {
                Console.WriteLine("Database Logged");
            }
        }
        class FileLogger: ILogger
        {
            public void Log()
            {
                Console.WriteLine("File Logged");
            }
        }

        interface ILogger
        {
            void Log();
        }
    }
}
