using System;

namespace ArraySınıfıMethodları
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 11, 2, 31, 14, 25, 46, 57, 38 };
            foreach (int item in dizi)
            {
                Console.Write(" {0} ", item);
            }
            Console.WriteLine();
            //dizi deki elemanları sıralar....
            Array.Sort(dizi);
            foreach (int item in dizi)
            {
                Console.Write(" {0} ", item);
            }
            // Verilen elemandan başlayarak sıfırlar kaç terime sıfır atayacağını ifade eder.
            Array.Clear(dizi, 2, 2);
            Console.WriteLine();
            foreach (int item in dizi)
            {
                Console.Write(" {0} ", item);
            }
            Console.WriteLine();
            //Diziyi tersten sıralar....
            Array.Reverse(dizi);
            foreach (int item in dizi)
            {
                Console.Write(" {0} ", item);
            }
            Console.WriteLine();
            //IndexOf dizinin elemanlarının kaçıcı index te olduğunu ifade eder.
            Console.WriteLine(Array.IndexOf(dizi, 57));
            //Resizde yeniden boyutlandırma
            Array.Resize(ref dizi, 5);
            // Ya da
            // Array.Resize(ref dizi, 5);
            foreach (int item in dizi)
            {
                Console.Write(" {0} ", item);
            }
        }
    }
}
