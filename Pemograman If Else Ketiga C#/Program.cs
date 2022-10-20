using System;

namespace Latihan3
{
    class Program
    {
        static void Main(string[] args)
        {
            int bilangan1, bilangan2 = 0;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Perbandingan Nilai Berdasarkan Kondisi");
            Console.WriteLine("---------------------------------------------");
            Console.Write("jumlah Bilangan Pertama =");
            bilangan1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Jumlah Bilangan Kedua =");
            bilangan2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Hasil Perbandingan");
            Console.WriteLine($"bilangan1 > bilangan2 : {bilangan1 > bilangan2}");
            Console.WriteLine($"bilangan1 >= bilangan2 : {bilangan1 >= bilangan2}");
            Console.WriteLine($"bilangan1 < bilangan2 : {bilangan1 < bilangan2}");
            Console.WriteLine($"bilangan1 <= bilangan2 : {bilangan1 <= bilangan2}");
            Console.WriteLine($"bilangan1 == bilangan2 : {bilangan1 == bilangan2}");
            Console.WriteLine($"bilangan1 != bilangan2 : {bilangan1 != bilangan2}");
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
