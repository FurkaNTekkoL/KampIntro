using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()                     // MyList class'ını bir yerde new'lersek constructor bloğu otomatik çalışır. 0 elemanlı bir array yaptık.
        {
            items = new T[0];
        }
        public void Add(T item)             // Bu metoda T tipinde elemanlar eklemek için new'lenmesi gerekiyor.Contructor ile bunu yapmış olduk.
        {
            T[] tempArray = items;          // New' lendiğinde eski referansımızın kaybolmaması için "Geçici Dizi" oluşturup eski referansı atadık.
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];    // TempArray 'e atadığımız eski referansın elemanlarını geri çağırdık.
            }

            items[items.Length - 1] = item;  // Anlamı: items'ın sonuncu(items.length-1) indexi = gönderdiğimiz item.
        }
    }
}
