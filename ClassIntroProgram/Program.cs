using System;

namespace ClassIntroProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 90;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.KursunEgitmeni = "Barış DAL";
            kurs2.IzlenmeOrani = 100;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursunEgitmeni = "Ulaş CUMART";
            kurs3.IzlenmeOrani = 75;

            //Console.WriteLine("Hello World!");
            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursunEgitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};
            /// yukarıda ifade ile pythondaki listeler gibi
            /// array oluşturmamıza olanak sağlıyor...
            /// ne bok bir syntax amk
            
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursunEgitmeni);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
