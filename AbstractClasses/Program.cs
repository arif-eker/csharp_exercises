using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();

            Console.ReadLine();

        }
    }


    abstract class Database
    {

        //tamamlanmış metot
        public  void Add()
        {

            Console.WriteLine("Added by default");
        }


        //tamamlanmamış metot
        public abstract void Delete();
        

    }

    class SqlServer : Database
    {   
        

        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql Server");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }




}
