using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names = new string[5];
            //names[4] = "İlker";
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[0]);     // Yeniden new 'lendiği için farklı bir referans oluştu ve eski dizi elemanlarını kaybetti.
            //                                 // Gelen dataya yeni bir eleman eklenemiyor.Bu yüzden dizi yerine çoğunlukla koleksiyonlar kullanılır.

            List<string> names2 = new List<string> {"Engin","Murat","Kerem","Halil" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("İlker");               // Koleksiyonların Add metodunu kullandık.
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
        }
    }
}
