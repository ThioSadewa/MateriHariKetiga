using System;
class Program
{
    static void Main(string[] args) {        
        int angka = 6;
        if (angka < 5) 
        {
            Console.WriteLine ($"{angka} kurang dari 5");
        }
        else if (angka > 5)
        {
            Console.WriteLine($"{angka} lebih dari 5 ");
        }      
        else if (angka == 6)
        {
            Console.WriteLine($"{angka} Sama dengan 6 "); 
        }
        else 
        {
            Console.WriteLine ("Angka yang dimasukkan tidak valid!");
        }
    }
}