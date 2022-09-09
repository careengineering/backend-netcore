using System;

namespace backend_netcore
{
   class Program
    {
        static void Main(string[] args)
        {
/******************** TRY - CATCH ÖRNEK - 1
          
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
*/

/******************** TRY - CATCH ÖRNEK - 2
            try
            {
                //int a = int.Parse(null);     //ArgumentNullException
                //int a = int.Parse("test");    //FormatException
                int a = int.Parse("-2000000000000000000"); 
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil  ");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("çok küçük yada çok büyük bir değer girdiniz");
                Console.WriteLine(ex);
            }

            finally
            {
                Console.Write("İşlem tamamlandı.");
            }
*/




        }
    }
}