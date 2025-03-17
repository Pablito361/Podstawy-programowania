using System;


namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to
            liczba parzysta, czy też nieparzysta. */
            int a;
            Console.Write("Podaj liczbe całkowitą: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
                Console.WriteLine("Liczba {0} jest parzysta ", a);
            else
                Console.WriteLine("Liczba {0} jest nieparzysta", a);
            Console.ReadKey(true); 

        }
    }
}
