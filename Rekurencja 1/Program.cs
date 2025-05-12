using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurencja_1
{
    class Program
    {
        // definicja funkcji rekurencyjnej
        static long silnia(int n)
        {
            if (n == 0) return 1;
            else return n * silnia(n - 1);
        }

        //przykladowe uzycie funkcji rekurencyjnej
        static void Main(string[] args)
        {
            Console.Write("Podaj n=");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) Console.WriteLine("Bledny argument!");
            else Console.WriteLine("{0}!={1}", n, silnia(n));
            Console.ReadKey(true);
        }
    }
    
}
