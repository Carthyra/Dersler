using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            /// sayi1 30 da kalıyor.
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999 ;
            /// burada sayilar1[0] eleman 999 olarak çıkıyor.
            Console.WriteLine(sayilar1[0]);

        }
    }
}
/// metodlarda devam ediyoruz ancak bu ara konu önemli bir konu
/// yukarıda array içerisinde güncel değerin gelemesinin nedeni
/// int decimal double float bool (boolean)  değer tip olarak adlandırılıyor
/// array, class, interface bunlar ise referans tip olarak çıkıyor.
/// bir değişken tanımlandığında int sayı (değer tip olanlar) ramde stack te oluyor.
/// ama referans tip tanımladığımızda ise ram de heap kısmında oluyor.
/// heap sanırım sürekli kendisini güncelliyor.
/// design pattern bunlara bakalım
///
/// int x = 1 dediğimiz zaman x değişkeni ve karşısındaki değer stack te tutuluyor.
/// ancak int y[] = new int[] {1,2,3,4,5} dediğimiz zaman y ismi stackte
/// yenin karşısındaki dizi ise heap tarafında tutuluyor.
/// ben y nin stack tutulan pointer adresini değiştirdiğim zaman ise
/// heapte kalan değerler boşa düşüyor. bu nedenle yukarıdaki örnekte sayılar1[0]
/// sayılar1 in pointerını sayılar 2 yaptığmız için {10,20,30} boşta kalıyor.
/// sayılar2 nin elemanları sayılar 1 e geçmiş oluyor. daha sonra sayılar2 nin [0]
/// elemanı değiştirildiğinde dolayısıyla sayılar1[0] elemanıda değişmiş oluyor.