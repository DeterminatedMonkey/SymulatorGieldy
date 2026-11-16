namespace SymulatorGieldy
{
    public class Spolka
    {
        public string Nazwa { get; set; }
        public string Branza { get; set; }
        public long LiczbaAkcji { get; set; }
        public decimal KapitalZakladowy { get; set; }
        public Akcja Akcja { get; set; }
    }
}
