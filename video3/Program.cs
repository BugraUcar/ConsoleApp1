using System;

namespace Metodlar

{
    class Program
    {
        static void Main(string[] args)
        {
          

            //Class ile daha kolay

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklamasi = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklamasi = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] {urun1,urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklamasi);
                Console.WriteLine("---------------------------------");
            }

            Console.WriteLine("-----------------Metodlar----------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Elma", "Yeşil" , 12);

           

            


        




        
        

            

        }


        
            







    }
    



}