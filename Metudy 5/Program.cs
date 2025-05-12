using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metudy_5
{
    internal class Program
    {
        //funkcja sprawdza czy jej argument jest liczba pierwsza
        static int czy_pierwsza(int liczba)
        {
            int i;
            for (i = 2 ; i < liczba / 2; i++)
                if (liczba % i == 0) return 0;
            return 1;
        }

        static void Main(string[] args) 
        {
             Console.WriteLine("Czy 12 jest l. pierwsza: {0}", czy_pierwsza(12));
             Console.WriteLine("Czy 13 jest l. pierwsza: {0}", czy_pierwsza(13));
             Console.ReadKey(true); 
        }
    }
}
