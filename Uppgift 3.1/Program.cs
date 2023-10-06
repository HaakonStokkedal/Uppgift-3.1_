using System;

namespace Uppgift_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder>=16 && ålder<=19)
                Console.WriteLine("Du får var med på festen");
            else
                Console.WriteLine("Du får inte vara med på festen.");

            Console.ReadKey();
        }
    }
}