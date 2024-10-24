
using System;
class Program
{
    static void Main()
    {
        int liczba = Convert.ToInt32(Console.ReadLine());
        if (liczba % 2 == 0) {
            Console.WriteLine("jest parzysta");
        }
        else
        {
            Console.WriteLine("nie jest parzysta");
        }
        for (int i = 0; i < liczba; i++) {
            if (i % 2 == 0) { 
                Console.WriteLine(i);
            }
        }
       

    }
}
