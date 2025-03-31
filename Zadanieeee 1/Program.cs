using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanieeee_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int i, n;

            Console.Write("Podaj ilość elementów tablicy n<=1000: ");
            n=Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj tab[{0}]=");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("elementy tablicy: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}, ", tab[i]);
            }
            Console.ReadKey(true);
        }
    }
}
