using System;

namespace LatihanIf
{
    class Latihan2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.Write("APAKAH ANDA INGIN LOGIN ? (ya/tidak) :");
            string? login = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------");
            if (login == "ya" || login == "YA") {
                Console.WriteLine($"Anda memilih {login}, Login Berhasil!");
            }
            else if (login == "tidak" || login == "TIDAK") {
                Console.WriteLine($"Anda Memilih {login}, Login Gagal!");
            }
            else {
                Console.WriteLine("Pilihan Tidak Sesuai, Login Gagal!");
            }
            Console.WriteLine("");
        }
    }
}



