using System;
using System.Collections.Generic;
using System.Text;
namespace GenericsIntro
{
    public class MyList<T>
    {
        T[] items;
        // classın bütün elemanlarının erişebileceği bir array
        // ancak bir arrayi new lemek gerekiyor.
        public MyList()
        {
            items = new T[0];
            // new leyerek arrayi oluşturdum ve 0 elemanlı
            // olarak verdim bu yapı constructor
            // bir class new lendiğinde otomatik çalışır
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

            }
            items[items.Length - 1] = item;

        }

        public int Count
        {
            get { return items.Length; }
        }
       
    }
}
