using System;

namespace inlämnings2__2
{
    class Program
    {
        static void Main(string[] args)
        {
            double tal1 = 2.4;
            double tal2 = 4.2;
            double tal3 = 3.2;
            double MedelVärdet = BeräknaMedel(tal1, tal2, tal3);
            Console.WriteLine("Medelvärdet: " + MedelVärdet);
        }

        static double BeräknaMedel(double tal1, double tal2, double tal3)
        {
            return (tal1 + tal2 + tal3) / 3;
        }
    }
}

