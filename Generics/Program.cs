using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Adana","Ankara");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }



            List<Customer> result2 = utilities.BuildList<Customer>(new Customer{FirstName = "Arif"});
            foreach (var  customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }
            
            Console.ReadKey();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {

            return new  List<T> (items);
        }
    }

    interface IProductDal:IRepository<Product>
    {
        //List<Product> GetAll();
       // Product Get(int id);
       // void Add(Product product);
        //void Delete(Product product);
        //void Update(Product product);
    }

    class Product:IEntity
    {
        
    }


    interface ICustomerDal:IRepository<Customer>
    {
       // List<Customer> GetAll();
       // Customer Get(int id);
        //void Add(Customer customer);
        //void Delete(Customer customer);
       // void Update(Customer customer);
    }

    class Customer:IEntity
    {
        public string FirstName { get; set; }

    }

    //generic kısıtlar  class demek referans tip alır.
    // new () : T bir sınıf olmalıdır.
    //IEntity . T ıEntityi implemente etmelidir.
    interface IRepository <T> where T: class,IEntity, new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }


    class ProductDal:IProductDal
    {
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal :ICustomerDal
    {

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }

    interface IEntity
    {
        
    }

    interface IStudentDal:IRepository<Student>
    {
        
    }

    class StudentDal:IStudentDal
    {
        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Student entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Student entity)
        {
            throw new NotImplementedException();
        }
    }
    class Student: IEntity
    {
        
    }

}
