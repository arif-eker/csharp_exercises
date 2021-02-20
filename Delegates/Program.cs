using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    public delegate void MyDelegate();

    public delegate void MyDelegate2(string text);

    public delegate int MyDelegate3(int a, int b);

    public class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customer = new CustomerManager();
            MyDelegate myDelegate = customer.SendMessage;

            myDelegate();
            // toplar gibi yapılabilir.
            Console.Write("\nMetot eklendi : ");
            myDelegate += customer.ShowAlert;

            myDelegate();

            //metot çıkarılabilir
            myDelegate -= customer.SendMessage;

            Console.Write("\nMetot Çıkarıldı : ");
            myDelegate();

            MyDelegate2 myDelegate2 = customer.ShowAlert2;
            myDelegate2("MyDelegate 2 text");

            Matematik matematik = new Matematik();

            MyDelegate3 myDelegate3 = matematik.Topla;
            Console.WriteLine("Delegate 3 : "+myDelegate3(3,4));
            

            Console.ReadKey();
        }
    }


    public class CustomerManager
    {


        public void SendMessage()
        {

            Console.WriteLine("Hello!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Careful!");
        }
        public void ShowAlert2(string key)
        {
            Console.WriteLine("{0}", key);
        }
    }

    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
