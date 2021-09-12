using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategoriler";
            int ogrenciSayisi = 28000;
            double faizOranı = 1.52;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 6.35;
            double dolarBugun = 6.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }


            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
