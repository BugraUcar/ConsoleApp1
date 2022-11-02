using System;

namespace Proje
{
    class MusteriManager
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Bugra";
            musteri1.Maasgunu = 15;
            musteri1.Maasi = 7500;
            musteri1.Yasi = 25 ;


            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Kaan";
            musteri2.Maasi = 8000;
            musteri2.Maasgunu = 15;
            musteri2.Yasi = 29;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            Musteri.Ekle(musteri1);
            Musteri.Ekle(musteri2);
            

                
            
        }
    }

    
        
}

