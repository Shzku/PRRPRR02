namespace MediaBibliotek
{
    public class Bok : Media
    {
        protected int antalSidor = 0;

        public Bok(string titel, int antalSidor) : base(titel)
        {
            this.antalSidor = antalSidor;
        }

        public override string ToString()
        {
            return titel + ": " + antalSidor + " sidor";
        }
    }
}