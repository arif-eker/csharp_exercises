using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer
            {
                Id = 1,
                
                LastName = "Eker",
                Age = 22
            };



            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);

            Console.ReadKey();
        }
    }

    //veritabanında Customers tablosuna karşılık gelir.
    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }

        //[RequiredProperty]
        public string  FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }

    class CustomerDal
    {

        //hazır attribute
        [Obsolete ("Bu metot eskidi, yeni metot : AddNew")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added1", 
                customer.Id,customer.FirstName,
                customer.LastName,customer.Age);
        }


        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added1",
                customer.Id, customer.FirstName,
                customer.LastName, customer.Age);

        }
    }


    //herkese kullanabilirsin diyoruz.
    //All yerine class dersek bu attrübuteyi sadece classlarda kullanabilirsin.
    //property dersen özelliklerde kullanır
    //ek için | kullanılır

    //attributeyi üst üste kullanmak için allow multiple

    [AttributeUsage(AttributeTargets.Property| AttributeTargets.Field,AllowMultiple = true)]
    class RequiredPropertyAttribute: Attribute
    {
        

    }

    [AttributeUsage(AttributeTargets.Class)]
    class ToTableAttribute:Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }


}
