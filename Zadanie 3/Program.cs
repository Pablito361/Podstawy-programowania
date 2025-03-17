using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Podaj liczbe nr 1:");
            a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbe nr 2:");
            b=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbe nr 3:");
            c=Convert.ToDouble(Console.ReadLine());
            if ((a <= b) && (a <= c))
                Console.WriteLine("Liczba {0} jest najmniejsza.", a);
            else if ((b <= a) && (b <= c))
                Console.WriteLine("Liczba {0} jest najmniejsza.", b);
            else
                Console.WriteLine("Liczba {0} jest najmniejsza.", c);

            if ((a>=b) && (a>=c))
                Console.WriteLine("Liczba {0} jest najwieksza.", a);
            else if ((b>=a) && (b>=c))
                Console.WriteLine("Liczba {0} jest najwieksza.", b);
            else
                Console.WriteLine("Liczba {0} jest najwieksza.", c);
            Console.ReadKey(true);
        }
    }
}
