using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //İlk Örnek

            // ArrayList();


            //2. Örnek

            //List();

            //3. Örnek

            //Dictionary
            //ilk verilen anahtar hangi tür, ikinci parametre (değeri) hangü türde

            //bir anahtarla değere ulaşmak hedeflendiği için kullanılır.

            Dictionary<string,string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book","kitap");
            dictionary.Add("table","tablo");
            dictionary.Add("computer","bilgisayar");

            Console.WriteLine(dictionary["table"]);
            // Console.WriteLine(dictionary["tablo"]);      hata verir.

            foreach (var item in dictionary)
            {
                Console.WriteLine("Key : "+item.Key+"\tValue : "+ item.Value);
            }

           Console.ReadKey();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }


            //List<Customer>customers2= new List<Customer>
            //{

            //    new Customer(),
            //    new Customer()
            //};
            //customers2[0].FirstName = "Samet";
            //customers2[0].Id = 1;
            //customers2[1].FirstName = "Haluk";
            //customers2[1].Id = 2;

            //foreach (var customer in customers2)
            //{
            //    Console.WriteLine("Customer2 Id : "+customer.Id+"\nCustomer2 First Name : "+customer.FirstName);
            //}

            //List<Customer> customer3 = new List<Customer>
            //{
            //    new Customer{Id = 3,FirstName = "Melih"},
            //    new Customer{Id = 4,FirstName = "Mahmut"}
            //};

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer() {Id = 1, FirstName = "Arif"});
            customers.Add(new Customer() {Id = 2, FirstName = "Rabia"});

            foreach (var customer in customers)
            {
                //Console.WriteLine(customer);
                Console.WriteLine("Customer Id: " + customer.Id + "\nCustomer First Name : " + customer.FirstName);
            }


            //metotlar

            //eleman sayısını verir
            var count = customers.Count;

            var customer2 = new Customer
            {
                Id = 1, FirstName = "Mehmet"
            };
            customers.Add(customer2);


            //bizden customer dizisi aldı ve elimizdeki List'e alt alta ekledi.
            //2 yeni eleman böylece eklendi.

            customers.AddRange(new Customer[2]
            {
                new Customer {Id = 5, FirstName = "Ali"},
                new Customer {Id = 6, FirstName = "Ayşe"}
            });

            Console.WriteLine("\nListeniz artık {0} elemanlıdır.", customers.Count);
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer Name :" + customer.FirstName);
            }

            //listeyi temizler. eleman kalmaz.
            //customers.Clear();

            //şehirler içinde ankara varsa true döner yoksa false
            //cities.Contains("Ankara");

            //customers'in içinde customer2 var mı
            Console.WriteLine(customers.Contains(customer2));

            var index = customers.IndexOf(customer2);
            Console.WriteLine(index);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();

            cities.Add("Ankara");
            cities.Add("Adana");


            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //Console.WriteLine(cities[2]);
        }



    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }



}
