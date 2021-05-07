using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Eklenen musteri " + musteri.MusteriAdi +" " +musteri.MusteriSoyadi);
            
            //musteriler.Add(musteri);
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Silinen musteri " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }
        public void MusteriListeleme(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi);
            }
        }
        
    }
}
