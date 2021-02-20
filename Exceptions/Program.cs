using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionOne();


            
            //Deneme 1

            //try
            //{
            //    Find();
            //}
            //catch (RecordNotFoundException exception)
            //{
            //    Console.WriteLine(exception.Message);
                
            //}


            //Deneme 2

            //birçok catch blogu varsa bunu yap. Delegate
            //action kullanımı
            HandleException(() =>
            {
                //burada normal kodda yazabilir ya da metot olabilir fark etmez. çalıştırılacak kod blogudur burası
                Find();
            });



            Console.ReadKey();
        }

        private static void HandleException(Action action)
        {
            try
            {
                //yukarıdan alınan kod bloğunu çalıştır demek.
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                
            }
        }

        private static void Find()
        {
            List<string> students = new List<string>() {"Arif", "Mehmet", "Salih"};

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record not found");
            }
            else
            {
                Console.WriteLine("Record found!");
            }
        }

        private static void ExceptionOne()
        {
            try
            {
                //çalışma bloğu

                int[] numbers = new int[2] { 1, 2 };

                numbers[3] = 3;

                //burada hata olursa kod catch içine geçer

            }
            catch (IndexOutOfRangeException exc)
            {
                Console.WriteLine(exc.Message);

            }
            catch (Exception exception)
            {
                //ınnerexception metodu daha detaylı bilgi verir.
                Console.WriteLine(exception.Message);
            }

            //tüm hataların base'i Exception sınıfıdır.
        }
    }
}
