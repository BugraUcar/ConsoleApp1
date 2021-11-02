using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar

{
    class SepetManager
    {


        public void Ekle(Product urunler)

        {
            Console.WriteLine("Sepete Eklendi: " + urunler.Adi);
        }
        public void Ekle2(string urunAdi , string aciklama , double fiyat)
        {
            Console.WriteLine("Tebrikler , Sepete Eklendi: "+ urunAdi +"  "+ aciklama);



        }

    }
       
}
