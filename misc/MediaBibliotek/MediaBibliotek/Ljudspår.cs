namespace MediaBibliotek
{
    public class Ljudspår : Media
    {
        protected double spelTid = 0;

        public Ljudspår(string titel, double spelTid) : base(titel)
        {
            this.spelTid = spelTid;
        }
    }
}