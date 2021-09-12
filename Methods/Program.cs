using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elması";
            product1.StokAdedi = 10;

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır karpuzu";
            product2.StokAdedi = 20;

            Product[] products = new Product[] {product1,product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.StokAdedi);
                Console.WriteLine("--------------------");

            }
            Console.WriteLine("*****************************");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            Console.WriteLine("+++++++++++++++++++++");

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 20, 8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 36, 20);
        }
    }
}
