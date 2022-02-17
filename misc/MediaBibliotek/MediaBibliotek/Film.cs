namespace MediaBibliotek
{
    public class Film : Ljudspår
    {
        protected string upplösning = "";

        public Film(string titel, double spelTid, string upplösning) : base(titel, spelTid)
        {
            this.upplösning = upplösning;
        }
    }
}