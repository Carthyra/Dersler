using System;
namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" "+musteri.Soyad+" eklendi");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" "+musteri.Soyad+" silindi");
        }

        public void Listeleme(Musteri[] musteriler)
        {
            Console.WriteLine("Müşterilerimiz:");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Müşteri Id: "+musteri.MusteriId);
                Console.WriteLine("Müşteri Adı: "+musteri.Ad);
                Console.WriteLine("Müşteri Soyadı: "+musteri.Soyad);
                Console.WriteLine("Müşteri Adresi: "+musteri.Adres);
                Console.WriteLine("Müşteri Telefon Numarası: "+musteri.TelefonNo);
                Console.WriteLine("-------------------------------------------");
            }
        }
    }
}
