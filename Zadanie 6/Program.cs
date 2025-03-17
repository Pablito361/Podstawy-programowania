using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int miesiac;
            Console.WriteLine("Podaj numer miesiaca: ");
            miesiac=Convert.ToInt32(Console.ReadLine());
            switch (miesiac)
            {
                case 1: Console.WriteLine("styczen");       break;
                case 2: Console.WriteLine("luty");         break;
                case 3: Console.WriteLine("marzec"); break;
                case 4: Console.WriteLine("kwiecien");        break;
                case 5: Console.WriteLine("maj");       break;
                case 6: Console.WriteLine("czerwiec");      break;
                case 7: Console.WriteLine("lipiec");            break;
                case 8: Console.WriteLine("sierpien");            break;
                case 9: Console.WriteLine("wrzesien");            break;
                case 10: Console.WriteLine("pazdziernik");            break;
                case 11: Console.WriteLine("listopad");            break;
                case 12: Console.WriteLine("grudzien");           break;
                default: Console.WriteLine("Nie ma takiego miesiaca!");   break;



            }
            
            Console.ReadKey(true); 

        }
    }
}
