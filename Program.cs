using System;

namespace backend_netcore
{
   class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1: 
                    Console.WriteLine("Ocak");
                    break;

                case 2: 
                    Console.WriteLine("Şubat");
                    break;

                 case 9: 
                    Console.WriteLine("Eylül");
                    break;                   

                default:
                    Console.WriteLine("Yanlış Veri Girişi");
                break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış");
                    break;

                case 3:
                case 4:
                case 9:
                    Console.WriteLine("Bahar");
                    break;
                default:
                break;
            }




        }
    }
}