using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rok;
            Console.WriteLine("Podaj rok: ");
            rok=Convert.ToInt32(Console.ReadLine());
            if (((rok % 4 == 0) && (rok % 100 != 0)) || (rok % 400 == 0))
                Console.WriteLine("rok {0} jest przestepny.", rok);
            else
                Console.WriteLine("rok {0} nie jest przestepny .", rok);
            Console.ReadKey(true); 
        }
    }
}
