using System;

namespace ödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] urunler = new string[] { "Halı", "Tekstil", "Züccaciye", "Elektronik" };

            for (int i = 0; i < urunler.Length; i=i+1)
            {
                Console.WriteLine(urunler[i]);
            }
            Console.WriteLine("Ürün Listesi Bitti Yeni Ürün");

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun);

            }

            Console.WriteLine("foreach döngüsü bitti");

            int a = 0;

            while (a < urunler.Length)
            {

                Console.WriteLine(urunler[a]);
                a++;

            }

            Console.ReadLine();











        }   
    }
}
