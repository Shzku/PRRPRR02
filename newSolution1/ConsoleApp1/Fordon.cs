using System;

namespace ConsoleApp1
{
    public class Fordon
    {
        protected int ägareId;

        public Fordon(int f_ägare)
        {
            ägareId = f_ägare;
        }

        public void utskrift()
        {
            Console.WriteLine("ägarId: "+ ägareId);
        }
    }
}