using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            var b = Console.ReadLine();
sdf            int x = Convert.ToInt32(a);
            int y = Convert.ToInt32(b);

            string durum = (x > y) ? "büyük" : (x < y) ? "küçük" : "eşit";

            switch (durum)
            {
                case "büyük": Console.WriteLine("A sayısı B'den büyüktür.");
                    break;
                case "küçük": Console.WriteLine("A sayısı B'den küçüktür.");
                    break;
                case "eşit":
                    Console.WriteLine("A sayısı B'ye eşittir");
                    break;
            }

        }
    }
}
