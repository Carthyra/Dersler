using System;
namespace Metodlar
{
    public class SepetManager
    {
        /// <summary>
        /// void ekle diyerek ekle isminde metot ekledik. bunu eklediğimiz metodu.
        /// program.cs içerisine aldık.
        /// SepetManager sepetmanager = new SepetManager(); ifadesi ile SepetManager
        /// ifadesi ile burada bulunan bütün fonksiyonları aldık programımızın içerisine.
        /// </summary>
        /// <param name="urun"></param>
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.UrununAdi);

        }
        /// <summary>
        /// bu ifade ile yapılan şey sıkıntılı bunu metod olarak eklerken
        /// sürekli olarak sistemde parametrelerin aldıkları argümanları güncellememiz
        /// gerekecek... bunun önüne geçebilmek için. Ekle2 metodunun içerisine aldığımız
        /// parametleri urun isimli classta tanımlamamız daha doğru...
        /// bunun classa eklenmesi encapsulation
        /// </summary>
        /// <param name="UrununAdi"></param>
        /// <param name="Aciklama"></param>
        /// <param name="Fiyat"></param>
        public void Ekle2(string UrununAdi, string Aciklama, double Fiyat)
        {
            Console.WriteLine(UrununAdi,Aciklama,Fiyat);
        }

        public void Goster(Urun urun)
        {
            Console.WriteLine("Sepetteki ürün :" + urun.Aciklama);
        }
    }
}
