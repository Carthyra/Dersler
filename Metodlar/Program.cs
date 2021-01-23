using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Urun urun1 = new Urun(); /// bu ifade urun clası içerisinde elma ürününü oluşturuyor.
            urun1.UrununAdi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.Id = 1;

            Urun urun2 = new Urun();
            urun2.UrununAdi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.Id = 2;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrununAdi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }
            // instace yapısı büyük harfli olan sepet manager clası buraya çağırdık gibi...

            SepetManager sepetmanager = new SepetManager();

            sepetmanager.Ekle(urun1);
            sepetmanager.Goster(urun1);
            sepetmanager.Ekle(urun2);
            sepetmanager.Goster(urun2);
            sepetmanager.Ekle2("Elma","Amasya Elması",15);
        }
    }
}
