using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriID = 25;
            musteri1.musteriAdi = "Mehmet";
            musteri1.musteriSoyAdi = "Osman334";
            

            Musteri musteri2 = new Musteri();
            musteri2.musteriID = 25;
            musteri2.musteriAdi = "Mehmet2";
            musteri2.musteriSoyAdi = "Osman2";

            Musteri musteri3 = new Musteri();
            musteri3.musteriID = 25;
            musteri3.musteriAdi = "Mehmet3";
            musteri3.musteriSoyAdi = "Osman3";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Sil(musteri3);
            Console.WriteLine("------------------");

        }
    }
}
