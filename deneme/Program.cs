using System;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun prod1 = new Urun();
            prod1.Adi = "Fanatec CSL Elite";
            prod1.Kategori = "Belt Drive";
            prod1.Fiyati = 1400;
            prod1.StokDurumu = "Stokta Var";

            Urun prod2 = new Urun();
            prod2.Adi = "Fanatec CSW";
            prod2.Kategori = "Belt Drive";
            prod2.Fiyati = 1800;
            prod2.StokDurumu = "Stokta Var";

            Urun prod3 = new Urun();
            prod3.Adi = "Fanatec Podium DD1";
            prod3.Kategori = "Direct Drive";
            prod3.Fiyati = 2400;
            prod3.StokDurumu = "Stokta Yok";

            Urun prod4 = new Urun();
            prod4.Adi = "Fanatec Podium DD2";
            prod4.Kategori = "Direct Drive";
            prod4.Fiyati = 2800;
            prod4.StokDurumu = "Stokta Var";

            Urun[] urunler_arrray = new Urun[] { prod1, prod2, prod3, prod4 };

            Console.Clear();

            Console.WriteLine("For Döngüsü");
            Console.WriteLine("--------------------");
            for (int i = 0; i < urunler_arrray.Length; i++)
            {
                Console.WriteLine(urunler_arrray[i].Adi);
                Console.WriteLine(urunler_arrray[i].Kategori);
                Console.WriteLine(urunler_arrray[i].Fiyati);
                Console.WriteLine(urunler_arrray[i].StokDurumu);
            }

            Console.WriteLine("---------------------");
            Console.WriteLine("For Each Döngüsü");
            Console.WriteLine("---------------------");
            foreach (Urun urun in urunler_arrray)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Kategori);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.StokDurumu);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("While Döngüsü");
            Console.WriteLine("----------------------");

            int counter = 0;
            while (counter < urunler_arrray.Length)
            {
                Console.WriteLine(urunler_arrray[counter].Adi);
                Console.WriteLine(urunler_arrray[counter].Kategori);
                Console.WriteLine(urunler_arrray[counter].Fiyati);
                Console.WriteLine(urunler_arrray[counter].StokDurumu);
                counter++;
            }
        }
    }
    class Urun
    {
        public string Adi { get; set; }
        public string Kategori { get; set; }
        public string StokDurumu { get; set; }
        public int Fiyati { get; set; }
        
    }
}
