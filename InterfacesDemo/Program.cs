using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            IWorker[] workers= new IWorker[]
            {
                new Manager(), 
                new Worker(), 
                new Robot()

            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat [] eats= new IEat[2]
            {
                new Manager(), 
                new Worker()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

            Console.ReadKey();
        }
    }

    interface IWorker
    {
        void Work();
        
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker,IEat,ISalary
    {
        public void Work()
        {
            Console.WriteLine("Manager Working");
        }

        public void Eat()
        {
            Console.WriteLine("Manager Eating");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager Getting salary");
        }
    }


    class Worker : IWorker,IEat,ISalary
    {
        public void Work()
        {
            Console.WriteLine("Worker Working");
        }

        public void Eat()
        {
            Console.WriteLine("Worker Eating");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker Getting salary");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Working");
        }
    }
}
