using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi

            string[] kurslar = new string[] {"Yazılım","Başlangıç","Java" };

            for (int i = 0; i < kurslar.Length; i=i+1)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer"); 



            
            
            
            
            
            
            
            
            
            
                  
                    
         
        }
    }
}
