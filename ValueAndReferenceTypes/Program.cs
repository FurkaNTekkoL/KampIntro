using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;
            Console.WriteLine(number1);                  // 30  (int değer tip olduğu için (stack) 30 olarak kalır)
            Console.WriteLine(number2);                  // 65

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = numbers2;
            numbers2[0] = 999;
            Console.WriteLine(numbers1[0]);            // 999  (dizi referans tip olduğu için (heap) 999 olarak değişir)
            Console.WriteLine(numbers2[0]);            // 999
        }
    }
}
