using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            //Lesson 1
            //CustomerManager customerManager = new CustomerManager();

            //customerManager.Add();
            //customerManager.Update();

            //Console.WriteLine("\n*********************\n");

            //ProductManager productManager = new ProductManager();

            //productManager.Add();
            //productManager.Update();


            //ders 2
            // bir kullanım şekli
            Customer customer = new Customer();

            customer.City = "Bursa";

            //firstname set ettik.
            customer.FirstName = "Arif";
            customer.LastName = "Eker";
            customer.Id = 1;


            //2. kullanım şekli

            Customer customer2 = new Customer()
            {
                Id=2, City = "Ankara", FirstName = "Fatma", LastName = "Eker"


            };

            //first name'yi get ettik.
            Console.Write(customer2.FirstName);

            Console.ReadKey();

        }
    }

    


    
}
