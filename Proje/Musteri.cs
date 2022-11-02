using System;
using System.Collections.Generic;
using System.Text;

namespace Proje
{
    class Musteri
    {
        public string Adi { get; set; }
        public double Maasi { get; set; }
        public int Maasgunu { get; set; }
        public int Yasi { get; set; }

        internal static void Ekle(Musteri musteriler)
        {
            Console.WriteLine("Müşteri Bİlgileri : "+ musteriler.Adi);

        }
    }
}

