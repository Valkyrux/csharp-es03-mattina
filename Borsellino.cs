namespace csharp_es03_mattina
{
    internal class Borsellino
    {
        private int soldini;

        public Borsellino()
        {
            this.soldini = 0;
        }

        public void Add(int valore)
        {
            Console.Write("{0} + {1} = ",this.soldini, valore);
            this.soldini += valore;
            Console.Write("{0}\n", this.soldini);
        }
    }
}