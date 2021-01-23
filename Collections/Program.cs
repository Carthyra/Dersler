using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5];
            //// bu ifade ile yeni bir beş elemanlı bir array oluşturmuş olduk
            //isimler[4] = "İlker";
            //// bu ekleyemiyoruz arrayler başta verdiğimiz sınıra tabi.
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            ///// bunu dediğimiz zaman ise 5 elemanlı yeni bir isimler arayinin
            ///// 5 inci elemanı olarak ilker i bastı fakan daha sonra 0 ıncı
            ///// yani birinci elemaı istediğimiz zaman sorun oldu. çünkü 5 elemanlı
            ///// arrayimizin [0] elemanı boş.

            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}
            //// 5 elemanlı isimler arrayinin boş olduğu sadece 4 üncü elemanının ilker
            //// olduğu daha rahat görülebilir.
            //// append yok mu amk dilinde?

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2.Count);
            /// yukarıdaki List ifadesi isimler2 adında bir koleksiyon yaptık 4 elemanlı ve
            /// devamında ise isimler2.Add("") ile koleksiyonumuza bir isim daha ekledik.

        }
    }
}
