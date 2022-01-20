using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] sehirler = new string[3];
            Console.WriteLine("Şehirleri yazınız...");
            
           
            
            for(int i=0; i<sehirler.Length; i++)
            {
                sehirler[i]=Console.ReadLine();
            }

            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
           

            Console.WriteLine("*********************************************");*/







            /*int enKucukSayi;
            int[] sayilar = { 12, 57, 45, 32, 1, 3 };

                for (int i = 0; i < sayilar.Length; i++)
                 {
                    if (sayilar [i] <= enKucukSayi)
                     {
                    enKucukSayi = sayilar[i];
                     }
                 }
            Console.WriteLine(enKucukSayi);
                        
              Console.WriteLine("*********************************************");*/





            /*
            string[,] sehirler = new string[5, 3]
            {
                { "a","b","c" },
                { "d","e","f" },
                { "g","n","h" },
                { "s","i","j" },
                { "k","l","m" },
            };

            //çok boyutlu dizilerde getUpperBound komutu kullanırken for döngüsünde üst limit küçük eşittir olmalıdır.

            for (int i = 0; i <=sehirler.GetUpperBound(0); i++)
            {
                for (int j = 0; j <=sehirler.GetUpperBound(1); j++)
                {
                    Console.WriteLine(sehirler[i,j]);
                    
                }
            }
            Console.WriteLine(sehirler.GetUpperBound(0)+" "+sehirler.GetUpperBound(1));
             
            Console.WriteLine("*********************************************");*/






            string[] students = { "ayşe", "fatma", "tuğçe" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
