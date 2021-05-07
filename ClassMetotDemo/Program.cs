using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();

            musteri1.MusteriAdi = "Murat";
            musteri2.MusteriAdi = "Buket";
            musteri3.MusteriAdi = "Dilek";

            musteri1.MusteriSoyadi = "Baykal";
            musteri2.MusteriSoyadi = "Baykal";
            musteri3.MusteriSoyadi = "Baykal";

            musteri1.Id = 1;
            musteri2.Id = 2;
            musteri3.Id = 3;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(musteri1);
            musteriManager.MusteriListeleme(musteriler);
            musteriManager.MusteriSilme(musteri2);
        }
    }
}
