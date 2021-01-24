using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId= 1;
            musteri1.Ad = "Ulaş";
            musteri1.Soyad = "Cumart";
            musteri1.Adres = "Ankara";
            musteri1.TelefonNo = "Numara1";

            Musteri musteri2 = new Musteri
            {
                MusteriId = 2,
                Ad = "Gizem",
                Soyad = "Cumart",
                Adres = "Ankara",
                TelefonNo = "Numara2"
            };

           Musteri musteri3 = new Musteri();
           musteri3.MusteriId = 3;
           musteri3.Ad = "Bıdık";
           musteri3.Soyad = "Shorthair";
           musteri3.Adres = "Ankara";
           musteri3.TelefonNo = "Numara3";

           Musteri musteri4 = new Musteri
           {
               MusteriId = 4,
               Ad = "Pofuduk",
               Soyad = "Shorthair",
               Adres = "Ankara",
               TelefonNo = "Numara4",
           };

            Musteri musteri5 = new Musteri();
            musteri5.MusteriId = 5;
            musteri5.Ad = "Yumuş";
            musteri5.Soyad = "Sokak Kedisi";
            musteri5.Adres = "Ankara";
            musteri5.TelefonNo = "Numara5";

            // Musteri adlı classta müşretiler oluşturuldu

            MusteriManager musterimanager = new MusteriManager();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

            foreach (Musteri customer in musteriler)
            {
                musterimanager.Ekleme(customer);
            }

            foreach (Musteri costumer in musteriler)
            {
                musterimanager.Silme(costumer);
            }

            musterimanager.Listeleme(musteriler);
        }
    }
}
