using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

           // tanımlanabilir : IPerson ıps = new Student();

            ICustomerDal [] customerDals= new ICustomerDal[]
            {
                new SqlServerCustomerDal(), 
                new OracleCustomerDal(), 
            };

            
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                customerDal.Update();
                customerDal.Delete();
                
               
            }



            Console.ReadKey();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(new OracleCustomerDal());
            customerManager.Add(new SqlServerCustomerDal());
            
        }

        private static void InterfacesIntro()
        {
            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Arif",
                LastName = "Eker",
                Address = "Bursa/Gemlik"
            };


            Student student = new Student()
            {
                Id = 1,
                FirstName = "Fatma",
                LastName = "Eker",
                Department = "Low School"
            };

            PersonManager person = new PersonManager();
            person.Add(student);
            person.Add(customer);
        }


    }

    interface IPerson
    {
         int Id { get; set; }
         string FirstName { get; set; }
         string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("Name : "+person.FirstName
                            +"\nLast Name : "+person.LastName
                            +"\nId : "+person.Id);
        }
    }






}
