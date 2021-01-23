using System;

namespace KampIntro
{
        class Program
    {
        static void Main(String[] args)
        {
            string kategori_etiketi = "Kategori";
            string kategori = "Dersler";
            int sayi = 234;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }
            string sonuc = dolarDun>dolarBugun ? "Azalış Oku" : "Artış Oku";

            Console.WriteLine(sonuc);

            Console.WriteLine(kategori_etiketi);

            Console.WriteLine(kategori);

            Console.WriteLine(sayi);

            string[] kurslar = new string[]
            {
                "Yazılım geliştirici kampı",
                "Programlama başlanğıç için temel kurs",
                "Java",
                "C#",
                "c++",
                "Python",
                "5"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");
            Console.WriteLine("for each");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("for each bitti");
        }
    }
}
