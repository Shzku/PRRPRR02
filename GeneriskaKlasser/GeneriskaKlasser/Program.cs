using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace GeneriskaKlasser
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Queue<string> minKöNamn = new Queue<string>();
            int i, antal;
            string sökNamn;

            Console.Write("Hur många namn vill du mata in: ");
            antal = int.Parse(Console.ReadLine());

            for (i = 0; i < antal; i++)
            {
                Console.Write("Mata in namn " + (i+1) + ": ");
                minKöNamn.Enqueue(Console.ReadLine());
            }
            Console.WriteLine();
            
            Console.WriteLine("Första värdet i kön: " + minKöNamn.Peek());
            Console.WriteLine();

            Console.WriteLine("Vi tar nu bort det första namnet " + minKöNamn.Dequeue());
            Console.WriteLine();

            Console.WriteLine("Nu finns föjlande namn kvar: ");

            foreach (string n in minKöNamn)
            {
                Console.WriteLine(n);
            }

            //Uppgift 1
            Console.WriteLine("Uppgift 1");
            Console.Write("Sök för namn: ");
            sökNamn = Console.ReadLine();
            Console.Write("Finns namnet: ");
            Console.WriteLine(minKöNamn.Contains(sökNamn) ? "ja" : "nej");

            Console.ReadKey();
            
            //Uppgift 2
            Console.WriteLine("Uppgift 2");
            Stack<string> minStack = new Stack<string>();
            foreach (string n in minKöNamn)
            {
                Console.WriteLine("minstack.Push(" + n + ");");
                minStack.Push(n);
            }

            Console.ReadKey();
            
            Console.WriteLine("tar bort: " + minStack.Peek());

            Console.WriteLine(minStack.Pop() + " borttagen");

            //Uppgift 3
            Console.WriteLine("Uppgift 3");
            HashSet<string> minHashSet = new HashSet<string>();
            foreach (string n in minKöNamn)
            {
                minHashSet.Add(n);
            }

            Console.WriteLine("det finns: " + minHashSet.Count + " namn totalt");

            Console.Write("Sök efter namn: ");
            sökNamn = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("namnet " + sökNamn + (minHashSet.Contains(sökNamn) ? " finns" : " finns inte"));
            
            //Uppgift 4
            Console.WriteLine("Uppgift 4");
            Dictionary<int, string> minDict = new Dictionary<int, string>();
            i = 0;
            foreach (string n in minKöNamn)
            {
                minDict.Add(i, n);
                i++;
            }

            Console.WriteLine("Key, Value");
            foreach (KeyValuePair<int, string> n in minDict)
            {
                Console.WriteLine(n.ToString());
            }

            Console.WriteLine("Sök med nyckel: ");
            Console.WriteLine(minDict[Int32.Parse(Console.ReadLine())]);
            
            //Uppgift 5
            Console.WriteLine("Uppgift 5");
            SortedList<int, string> resultat = new SortedList<int, string>();
            resultat.Add(3, "Liisa");
            resultat.Add(1, "Alisha");
            resultat.Add(2, "Gwen");
            resultat.Add(4, "Mona");
            resultat.Add(10, "Hedvig");
            resultat.Add(5, "Lillemor");

            foreach (KeyValuePair<int, string> n in resultat)
            {
                Console.WriteLine(n.ToString());
            }
            
            Console.ReadKey();
        }
    }
}