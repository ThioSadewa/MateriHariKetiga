using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
           int angka = 0;
           Console.WriteLine("-- Mencari nilai yang sesuai sistem --");
           Console.Write("Silahkan input angka menurut anda benar: ");
           angka = Convert.ToInt32(Console.ReadLine());
            if (angka == 0) {
                Console.WriteLine("Nilai dari angka adalah 10");
                Console.WriteLine("Nilai yang tepat dari angka : {0}", angka + " Keberuntungan Untuk Anda");
                }
            else if (angka == 0) {
                Console.WriteLine("Nilai Dari angka adalah 20");
                Console.WriteLine("Nilai yang tepat adalah : {0}", angka + " Keberuntungan Untuk Anda"); 
                }
            else if (angka == 0) {
                Console.WriteLine("Nilai Dari angka adalah 30");
                Console.WriteLine("Nilai yang tepat adalah : {0}", angka + " Keberuntungan Untuk Anda"); 
                }
            else {
                Console.WriteLine("Tidak ada nilai yang cocok belum beruntung");
                Console.WriteLine("Nilai yang tepat adalah : {0}", angka + " Keberuntungan Untuk Anda");
            }
            Console.ReadLine();
        }
    }
}
