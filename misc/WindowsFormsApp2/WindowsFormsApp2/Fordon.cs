using System;

namespace WindowsFormsApp2
{
    public class Fordon
    {
        protected int ägareId;

        public Fordon(int f_ägare)
        {
            ägareId = f_ägare;
        }

        public string utskrift()
        {
            return ("ägarId: "+ ägareId);
        }
    }
}