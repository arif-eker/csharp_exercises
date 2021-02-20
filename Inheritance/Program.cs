using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person [] persons= new Person[3]
            {
                new Person{FirstName = "Person", LastName = "Person", Id = 1}, 
                new Customer{FirstName = "Customer", LastName = "Customer", Id = 2}, 
                new Student{FirstName = "Student", LastName = "Student", Id = 3}

            };

            
            foreach (var person in persons)
            {
                Console.WriteLine("First Name : "+person.FirstName+ "\nLast Name : "+person.LastName+"\nId : "+person.Id);
            }
            Console.ReadLine();

        }
    }



    class Person
    {
        public int  Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }

    }

    class Student : Person
    {
        public string Department { get; set; }
    }

}
