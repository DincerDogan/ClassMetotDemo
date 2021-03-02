using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi : " + musteri.musteriAdi + " " + musteri.musteriSoyAdi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi : " + musteri.musteriAdi + " " + musteri.musteriSoyAdi);
        }

        public void Listele(Musteri musteri)
        {

            Console.WriteLine("Müşteri Listelendi : " + musteri.musteriAdi);
        }
    }
}
