using System;

namespace backend_netcore
{
   class Program
    {
        static void Main(string[] args)
        {

          // Try-Catch  
            try
            {
            Console.WriteLine("Sayı Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girilen sayı:" + sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata : " + ex.Message.ToString());
            }
            finally
            {
                Console.Write("İşlem tamamlandı.");
            }

            try
            {
                int a = int.Parse(null);
            
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.Write("İşlem tamamlandı.");
            }

        }
    }
}