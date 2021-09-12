using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "C#";
            

            //Array-Dizi kullanımı

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", "Programlamaya başlangıç için temel kurs", "Java", "C#" };


            for (int i = 0; i < kurslar.Length; i++)                        //kurslar.Length => kurslar dizisinin eleman sayısı
            {
                Console.WriteLine(kurslar[i]);
            }


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
