using System;


namespace Kolokwium
{
    class Kula
    {
        public static void pierwsze(double r)
        {
            double powierzchnia, pojemnosc;
            pojemnosc = (4 / 3) * Math.PI * Math.Pow(r, 3); powierzchnia = 4 * Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Pole powierzchni: {0}\nPojemnosc: {1}", powierzchnia, pojemnosc);
        }
    }


    class Program
    {
        static double drugie(double[] ceny, double[] ilosci)
        {
            double koszt = 0;
            for(int i = 0; i < ilosci.GetLength(0); i++)
            {
                koszt = koszt + ceny[i] * ilosci[i];
            }
            return koszt;
        }

        static double trzecie(double[,] oceny)
        {
            double srednia = 0, waga = 0;
            for(int i = 0; i < oceny.GetLength(1); i++)
            {
                srednia = srednia + oceny[0, i];
                waga = waga + oceny[1, i];
            }

            return srednia/waga;
        }
        static void Main()
        {
            Console.WriteLine("Podaj promień kuli: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Kula.pierwsze(r);

            double[] ceny = { 17, 32.99, 1.99, 9.99, 3, 6, 8, 12.25 };
            double[] ilosci = { 3, 2, 17, 3, 7, 5, 2, 120 };
            Console.WriteLine($"Koszt zamówienia: {drugie(ceny, ilosci)}");

            double[,] oceny =
            {
                {5, 5, 5, 5, 2, 3.5, 2, 4 },
                {1, 1, 1, 1, 3, 1, 2, 3 }
            };

            Console.WriteLine("Srednia wazona ocen ucznia: {0}", trzecie(oceny));
        }
    }
}
