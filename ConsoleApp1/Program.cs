using System;
class Program
{
    static void Main()
    {

        //        int liczba = Convert.ToInt32(Console.ReadLine());
        //        if (liczba % 2 == 0) {
        //            Console.WriteLine("jest parzysta");
        //        }
        //        else
        //        {
        //            Console.WriteLine("nie jest parzysta");
        //        }
        //        for (int i = 0; i < liczba; i++) {
        //            if (i % 2 == 0) { 
        //                Console.WriteLine(i);
        //            }
        //}




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
using System;

public class Osoba
{
    private string imie;
    private string nazwisko;
    private int wiek;
    private string pesel;

    public Osoba(string imie, string nazwisko, int wiek, string pesel)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        Wiek = wiek;
        this.pesel = pesel;
    }

    public string Imie
    {
        get { return imie; }
        set { imie = value; }
    }

    public string Nazwisko
    {
        get { return nazwisko; }
        set { nazwisko = value; }
    }

    public int Wiek
    {
        get { return wiek; }
        set { wiek = value < 0 ? 0 : value; }
    }

    public string Pesel
    {
        get { return pesel; }
    }

    public string PrzedstawSie()
    {
        return $"Nazywam się {Imie} {Nazwisko} i mam {Wiek} lat.";
    }
}

public class Licz
{
    private int wartosc;

    public Licz(int wartosc)
    {
        this.wartosc = wartosc;
    }

    public void Dodaj(int liczba)
    {
        wartosc += liczba;
    }

    public void Odejmij(int liczba)
    {
        wartosc -= liczba;
    }

    public void WypiszStan()
    {
        Console.WriteLine($"Aktualна wartość: {wartosc}");
    }
}

public class Sumator
{
    private int[] liczby;

    public Sumator(int[] liczby)
    {
        this.liczby = liczby;
    }

    public int Suma()
    {
        int suma = 0;
        foreach (int liczba in liczby)
        {
            suma += liczba;
        }
        return suma;
    }

    public int SumaPodziel3()
    {
        int suma = 0;
        foreach (int liczba in liczby)
        {
            if (liczba % 3 == 0)
            {
                suma += liczba;
            }
        }
        return suma;
    }

    public int IleElementów()
    {
        return liczby.Length;
    }

    public void WypiszElementy()
    {
        Console.WriteLine("Elementy tablicy: " + string.Join(", ", liczby));
    }

    public void WypiszElementyWZakresie(int lowIndex, int highIndex)
    {
        for (int i = Math.Max(lowIndex, 0); i <= Math.Min(highIndex, liczby.Length - 1); i++)
        {
            Console.WriteLine($"Element[{i}] = {liczby[i]}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // 1
        Osoba osoba = new Osoba("Jan", "Kowalski", 30, "12345678901");
        Console.WriteLine(osoba.PrzedstawSie());
        osoba.Wiek = -5;
        Console.WriteLine(
            $"Age: {osoba.Wiek}");

        //2
        Licz licz = new Licz(10);
        licz.Dodaj(5);
        licz.Odejmij(3);
        licz.WypiszStan();

        //3
        int[] liczby = { 1, 2, 3, 6, 9, 12, 15 };
        Sumator sumator = new Sumator(liczby);
        Console.WriteLine($"sum {sumator.Suma()}");
        Console.WriteLine(
            $"Sum/ 3: {sumator.SumaPodziel3()}");
        Console.WriteLine($"{sumator.IleElementów()}");
        sumator.WypiszElementy();
        sumator.WypiszElementyWZakresie(2, 10);
    }
}
