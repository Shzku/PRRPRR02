using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cykel cykel1 = new Cykel(1, 4);
            Cykel cykel2 = new Cykel(2, 6);
            Personbil personbil1 = new Personbil(1, "HejHej", 4);
            Personbil personbil2 = new Personbil(2, "ByeBye", 6);
            Personbil personbil3 = new Personbil(1, "Sport", 2);
            Lastbil lastbil1 = new Lastbil(1, "Tung", 220);
            Lastbil lastbil2 = new Lastbil(2, "Snabb", 120);

            cykel1.nyUtskrift();
            personbil1.nyyUtskrift();
            personbil2.nyyUtskrift();
            lastbil1.nyyUtskrift();
            
            Console.ReadKey();
        }
    }
}