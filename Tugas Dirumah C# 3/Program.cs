using System;
class Program
{
    static void Main(string[] args) 
    {
        int bilangan1 , bilangan2;

        Console.WriteLine("");
        Console.Write("Masukkan Angka Pertama : ");
        bilangan1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Masukkan Angka Kedua : ");
        bilangan2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("");

        if (bilangan1 >= -10 || bilangan2 >= -10)
            {
                if (bilangan1 <= 10 || bilangan2 <= 10) 
                    {
                        Console.WriteLine("True");
                    }
                else
                    {
                        Console.WriteLine("False");
                    }
            }

        else {
            Console.WriteLine("False");
        }
        Console.WriteLine("");
    }
}