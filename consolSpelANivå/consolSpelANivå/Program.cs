using System;

namespace consolSpelANivå
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool villSpela = true;
            
            Console.WriteLine("Vad heter din spelare: ");
            Hero spelare = new Hero(Console.ReadLine(), 2000, 800, 500, 400);
            Console.WriteLine("=======================");
            
            
            while (villSpela)
            {
                Console.WriteLine("Vad vill du ha för motståndare (Skogstroll, Bergstroll eller Drake): ");
                switch (Console.ReadLine())
                {
                    case "Skogstroll":
                        Console.WriteLine("Vad heter skogstrollet: ");
                        SkogsTroll STroll = new SkogsTroll(Console.ReadLine(), 2000, 800, 400, 400);
                        STrollBattle(spelare, STroll);
                        break;
                    case "Bergstroll":
                        Console.WriteLine("Vad heter bergstrollet: ");
                        BergsTroll BTroll = new BergsTroll(Console.ReadLine(), 2000, 800, 400, 800);
                        BTrollBattle(spelare, BTroll);
                        break;
                    case "Drake":
                        Console.WriteLine("Vad heter drake: ");
                        Drake drake = new Drake(Console.ReadLine(), 2000, 800, 1000);
                        DrakeBattle(spelare, drake);
                        break;
                    default:
                        Console.WriteLine("Den motståndaren finns ej!");
                        break;
                }

                Console.WriteLine("vill du fortsätta(y/n)");
                villSpela = string.Equals(Console.ReadLine(), "y");
            }
        }

        static public void STrollBattle(Hero hero , SkogsTroll STroll)
        {
            int heroKvarHP, trollKvarHP;
            hero.Attack();
            STroll.Attack();

            heroKvarHP = hero.HeroHealth - STroll.STrollTotDamage;
            trollKvarHP = STroll.STrollHealth - hero.HeroTotDamage;
            
            Console.WriteLine("Din kvarvarande 'health': " + heroKvarHP);
            Console.WriteLine("Skogstrollet kvarvarande 'health': " + trollKvarHP);

            Console.WriteLine((heroKvarHP > trollKvarHP) ? "Spelaren vann" : "Skogstrollet vann");
            return;
        }
        
        static public void BTrollBattle(Hero hero , BergsTroll BTroll)
        {
            int heroKvarHP, trollKvarHP;
            hero.Attack();
            BTroll.Attack();

            heroKvarHP = hero.HeroHealth - BTroll.BTrollTotDamage;
            trollKvarHP = BTroll.BTrollHealth - hero.HeroTotDamage;
            
            Console.WriteLine("Din kvarvarande 'health': " + heroKvarHP);
            Console.WriteLine("Bergstrollet kvarvarande 'health': " + trollKvarHP);

            Console.WriteLine((heroKvarHP > trollKvarHP) ? "Spelaren vann" : "Bergstrollet vann");
            return;
        }
        
        static public void DrakeBattle(Hero hero , Drake drake)
        {
            int heroKvarHP, trollKvarHP;
            hero.Attack();
            drake.Attack();

            heroKvarHP = hero.HeroHealth - drake.DrakeTotDamage;
            trollKvarHP = drake.DrakeHealth - hero.HeroTotDamage;
            
            Console.WriteLine("Din kvarvarande 'health': " + heroKvarHP);
            Console.WriteLine("Drakens kvarvarande 'health': " + trollKvarHP);

            Console.WriteLine((heroKvarHP > trollKvarHP) ? "Spelaren vann" : "Draken vann");
            return;
        }
    }
}