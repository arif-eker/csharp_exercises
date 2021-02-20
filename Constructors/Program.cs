using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager1 = new CustomerManager();

            CustomerManager customerManager2 = new CustomerManager(25);

            customerManager1.List();
            customerManager2.List();

            Product product1 = new Product(){Id=1, Name = "Laptop"};

            Product product2 = new Product(2,"Computer");


            Console.WriteLine("************************\n");

            EmployeeManager employee = new EmployeeManager(new DatabaseLogger());
            //employee.Logger = new DatabaseLogger();
            employee.Add();

            Console.WriteLine("************************\n");

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Console.ReadKey();

        }
    }

    class CustomerManager
    {
        private int _count = 15;

        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {
            
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items",_count);
        }


        public void Add()
        {

            Console.WriteLine("Added!");
        }
    }

    class Product
    {
        private int _id;
        private string _name;

        public Product()
        {
            
        }
        public Product(int id, string name)
        {
            _id = id;
            _name = name;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database!");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File!");
        }
    }

    class EmployeeManager
    {
        //public ILogger Logger { get; set; }

        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = new DatabaseLogger();
        }
        public void Add()
        {
            //Logger.Log();
            _logger.Log();
            Console.WriteLine("Added");
        }
    }

    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }
       public void Message()
       {
            Console.WriteLine("{0}  message",_entity);

       }
    }

    class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity)
        {
            
        }

        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }
}
