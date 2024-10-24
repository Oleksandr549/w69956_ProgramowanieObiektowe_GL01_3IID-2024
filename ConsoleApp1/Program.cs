
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

        








        int liczba = Convert.ToInt32(Console.ReadLine());
        while (true)
        {
            Console.WriteLine("1.czy jest parzyste");
            Console.WriteLine("2.wypisz parzyste");
            Console.WriteLine("3.Silnia");
            Console.WriteLine("4.Wyjście");

            int wybor = Convert.ToInt32(Console.ReadLine());
            if (wybor == 1)
            {

                if (liczba % 2 == 0)
                {
                    Console.WriteLine("jest parzysta");
                }
                else
                {
                    Console.WriteLine("nie jest parzysta");
                }
            }
            if (wybor == 2)
            {
                for (int i = 0; i < liczba; i += 2)
                {
                    Console.WriteLine(i);
                }



            }
            if (wybor == 3)
            {
                static int silnia(int x)
                {
                    if (x == 0) return 1;
                    return silnia(x - 1) * x;
                }
                Console.WriteLine(silnia(liczba));
                if (wybor == 4)
                {
                    break;
                }
            }

        }
    }
}

